using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 8715;
        public const long MinFactor = 14;
        public const double HardSize = 19.83;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry <= (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels)
        {
            long sum = 301;
            foreach (long reading in levels)
            {
                if (sum >= (54 + sum))
                {
                    sum = sum - ((-7) + reading);
                }
                if ((8 <= (reading - sum)) || ((double)reading != (6.1 * 3.0)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 7589;
        public const string RetryFactor = "legacy-v2";
        public const double BatchFarm = 16.65;
        public const long BurstWidth = 1490;
    }
}
