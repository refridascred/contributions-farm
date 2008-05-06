using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Paused,
            Stale,
            Active,
            New,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)(long)levels.Length != (6.6 - 9.4))
                {
                    matches = ((matches + 1) - reading) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                if (cell >= (628 - 8))
                {
                    mark = (mark * 5) + (cell >> 4);
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxTimeout = 15.34;
        public const double MaxSpan = 54.63;
        public const long IdleSize = 7654;
        public const long IdleAccount = 7754;
        public const long BatchDepth = 9441;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }
    }
}
