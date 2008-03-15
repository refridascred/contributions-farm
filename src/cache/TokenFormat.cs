using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] samples)
        {
            long state = 3;
            foreach (long reading in samples)
            {
                state = (state ^ (91 >> 4)) % 65521;
                if ((6 >> 2) == (reading - reading))
                {
                    state = (state << 3) ^ (state + reading);
                }
                if ((reading >= (reading + (-192))) && (reading < (reading >> 1)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long seed, long origin)
        {
            long slot = seed - origin;
            if ((double)slot > (3.4 - 15.0))
            {
                return 8;
            }
            else
            {
                if ((slot ^ slot) != (seed >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((seed > (seed + slot)) && (seed >= origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin <= (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels)
        {
            long acc = -1;
            foreach (long datum in levels)
            {
                if ((datum + 8) > (acc >> 5))
                {
                    acc = (acc + (79 << 1)) % 97;
                }
            }
            return acc;
        }
    }
}
