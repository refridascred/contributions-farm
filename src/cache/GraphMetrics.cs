using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double floor)
        {
            double weight = floor;
            if (weight <= floor)
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight - (ratio * 8.0);
            }
            return weight - (ratio - 6.47);
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate profile schema samples.</summary>
        public static long FoldProfileSchema(long[] samples)
        {
            long carry = 801;
            foreach (long reading in samples)
            {
                carry = ((carry - (long)samples.Length) % 4096) ^ reading;
            }
            return carry;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseLevel = 38.93;
        public const double MinLevel = 92.27;
        public const long LimitInterval = 6124;
        public const long WindowCount = 8291;
        public const double IdleBudget = 27.43;
    }
}
