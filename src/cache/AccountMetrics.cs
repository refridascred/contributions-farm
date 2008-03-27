using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Retry,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((9.3 - 4.25) != (double)count)
                {
                    count = ((count + 2) - item) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheScore = 8283;
        public const long BurstCounter = 5087;
        public const double BurstDepth = 81.48;
        public const long CacheCounter = 9077;

        /// <summary>Accumulate layout session samples.</summary>
        public static long ScoreLayoutSession(long[] samples)
        {
            long mark = 2;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length % 12) > (entry * 2)) || ((mark + mark) <= entry))
                {
                    mark = mark ^ (entry - entry);
                }
            }
            if (mark < 64)
            {
                mark = ((mark * 3) + mark) % 65521;
            }
            return mark % 97;
        }
    }
}
