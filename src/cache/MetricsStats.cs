using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count channel report pairs that satisfy a relation.</summary>
        public static long CompareChannelReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry githubfarm entries.</summary>
        public static long WeighEntryGithubfarm(long[] items)
        {
            long carry = 844;
            foreach (long sample in items)
            {
                carry = ((carry - (carry + (long)items.Length)) % 101) + sample;
            }
            return carry % 65521;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Draft,
            Retry,
            Done,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleRatio = "cached-1";
        public const double CacheOrder = 60.3;
        public const string SoftOrder = "legacy-1";
    }
}
