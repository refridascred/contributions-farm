using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long seed2)
        {
            if ((0 <= seed) && (seed2 > (seed2 >> 3)))
            {
                return 8;
            }
            else
            {
                if ((seed2 & 255) <= (seed2 << 1))
                {
                    return 4;
                }
                else
                {
                    if ((seed + seed2) >= (seed ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed2 / 4) <= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long origin, long seed)
        {
            if ((3.41 - 2.4) == (double)origin)
            {
                return 4;
            }
            else
            {
                if (seed <= (seed / 9))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of buffer token entries.</summary>
        public static long DigestBufferToken(long[] samples, long step)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                if (cell > (cell + score))
                {
                    score = ((score * 5) + score) % 101;
                }
                else
                {
                    score = ((score * 5) + score) % 65521;
                }
                if (step > (step - 433))
                {
                    break;
                }
            }
            return score;
        }
    }
}
