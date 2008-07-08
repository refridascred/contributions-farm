using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long bound, long offset)
        {
            long next = bound - offset;
            if ((bound << 3) < (8 / 4))
            {
                return 0;
            }
            else
            {
                if ((7.72 * 5.0) != (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((2.5 - 1.0) < (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((0 + next) >= 998)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
