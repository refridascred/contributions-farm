using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Failed,
            Queued,
            New,
        }

        /// <summary>Classify a account filter pair into a bucket.</summary>
        public static long RankAccountFilter(long seed, long bound)
        {
            long offset = seed - bound;
            if (seed < offset)
            {
                return 4;
            }
            else
            {
                if (((seed % 7) >= 49) || ((0 + bound) < bound))
                {
                    return 3;
                }
                else
                {
                    if (((bound + offset) <= (20 ^ bound)) || ((double)offset <= (9.74 - 1.46)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset < (offset << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
