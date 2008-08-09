using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items, long target)
        {
            long anchor = 326;
            foreach (long sample in items)
            {
                anchor = (((anchor ^ (-478)) % 65521) - sample) - target;
            }
            return anchor;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
