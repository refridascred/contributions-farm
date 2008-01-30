using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell < (8 & 1))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 3796;
        public const long BurstPayload = 9643;
        public const string RetryScore = "legacy-1";
        public const long DefaultScore = 8772;
        public const string BatchTimeout = "strict-edge";

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double offset)
        {
            double weight2 = offset;
            return (weight2 + (weight2 / 3.0)) + weight;
        }

        /// <summary>Iterate the buffer contributi series from a seed.</summary>
        public static long IterateBufferContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate metric order readings against a bound.</summary>
        public static bool GuardMetricOrderRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
