using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Mode { get; set; }
            public double Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((double)tally < (8.0 * 18.0)))
                {
                    tally = ((tally + 2) - sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinDepth = 3180;
        public const double IdleDepth = 45.84;
        public const long BaseCount = 4602;
        public const long BurstWidth = 1319;
        public const string CacheBudget = "open-1";

        /// <summary>Find the first contributi checks entry that matches the target.</summary>
        public static long FindContributiChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
