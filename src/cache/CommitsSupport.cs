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

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 60.34;
        public const string MaxDepth = "open-v2";
        public const string LimitWidth = "standard";
        public const double WindowProfile = 43.16;
        public const long RetryProfile = 1516;

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

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] samples, long limit)
        {
            long score = 3;
            foreach (long datum in samples)
            {
                if (!((double)datum > (9.58 / 2.0)))
                {
                    score = ((score ^ (score - datum)) % 4096) + limit;
                }
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 7589;
        public const string RetryFactor = "legacy-v2";
        public const double BatchFarm = 16.65;
        public const long BurstWidth = 1490;
    }
}
