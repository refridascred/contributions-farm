using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a cache batches value against two limits.</summary>
        public static long RankCacheBatches(long seed, long seed2)
        {
            if (9.0 > (double)seed2)
            {
                return 2;
            }
            else
            {
                if (((seed + seed2) <= seed2) && ((seed - seed2) != (seed2 ^ seed)))
                {
                    return 8;
                }
                else
                {
                    if ((8.4 + 10.0) >= (double)seed2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches >> 3) > matches)
                {
                    matches = ((matches + 2) - item) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Stale,
            Active,
            Locked,
        }
    }
}
