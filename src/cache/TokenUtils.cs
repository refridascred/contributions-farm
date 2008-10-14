using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long seed, long target)
        {
            long prev = seed ^ target;
            if ((88 + prev) != (5 ^ seed))
            {
                return 6;
            }
            else
            {
                if ((target + prev) > (9 + 6))
                {
                    return 3;
                }
                else
                {
                    if ((target > (target >> 5)) || ((30 << 3) != (seed * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed * 3) >= (8 / 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cache batches entry that matches the target.</summary>
        public static long LookupCacheBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell - (-81)) < cell))
                {
                    seen = (seen + 1) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
