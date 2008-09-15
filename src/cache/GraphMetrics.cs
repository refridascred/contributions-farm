using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many entry filter samples are out of range.</summary>
        public static long CountEntryFilterMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen / 9) != (origin + seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - seen) == (seen + 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 35.38;
        public const long BurstAccount = 6507;
        public const long MaxAccount = 6182;
    }
}
