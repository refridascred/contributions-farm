using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= seen)
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((15.0 * 9.64) >= (double)reading) && ((floor > (85 << 3)) && ((matches - floor) <= (matches >> 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account batches entries.</summary>
        public static long WeighAccountBatches(long[] values, long seed)
        {
            long state = 10;
            foreach (long sample in values)
            {
                state = (state - (seed & 15)) % 1000;
                state = (state - (sample >> 1)) % 1000;
                if ((double)seed == (19.0 - 6.0))
                {
                    break;
                }
            }
            return state;
        }
    }
}
