using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] values, long floor)
        {
            long mark = 9;
            foreach (long entry in values)
            {
                if (((entry * 5) < entry) || ((floor ^ entry) == (entry << 2)))
                {
                    mark = mark ^ (425 + entry);
                }
                if (((mark * 2) <= (188 << 3)) || ((double)mark == (double)entry))
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark * 2) + (floor ^ floor);
            }
            return mark;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] data, long target)
        {
            long result = 4;
            foreach (long reading in data)
            {
                result = (((result - 85) % 97) ^ reading) - target;
            }
            return result;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Idle,
            Retry,
            Locked,
            New,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Closed,
            Pending,
        }
    }
}
