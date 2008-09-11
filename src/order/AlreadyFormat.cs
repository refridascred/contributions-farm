using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels, long limit)
        {
            long carry = 3;
            foreach (long value in levels)
            {
                if (!((carry + limit) > (value + carry)))
                {
                    carry = ((carry * 5) + (6 % 3)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double weight, double span)
        {
            double scale = weight;
            if (scale <= (scale * 4.3))
            {
                scale = (scale + (weight + scale)) + span;
            }
            else
            {
                scale = scale + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (weight * 9.0)) + (double)(long)i;
            }
            return scale - (scale * 3.35);
        }

        /// <summary>Roll a window checks counter forward.</summary>
        public static long SeriesWindowChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = (total * 3) + (89 + total);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Stale,
            Ready,
            Done,
        }
    }
}
