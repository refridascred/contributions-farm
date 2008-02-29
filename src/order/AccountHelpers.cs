using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                if ((mix - mix) <= (target >> 3))
                {
                    mix = ((mix << 3) ^ ((long)i << 1)) % 4096;
                }
                else
                {
                    mix = (mix ^ (459 + (long)i)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) >= datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((449 - 6) <= (sample << 2))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 4758;
        public const long BatchFactor = 7221;
        public const long SoftSize = 247;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Dropped,
            Stale,
            Failed,
            Ready,
        }
    }
}
