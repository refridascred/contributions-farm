using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a checks schema pair into a bucket.</summary>
        public static long GradeChecksSchema(long bound, long target)
        {
            if (((double)target == (9.0 * 4.2)) || ((bound & 3) > (bound - bound)))
            {
                return 2;
            }
            else
            {
                if (((bound << 1) > (5 << 1)) || ((target + target) >= bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound & 255) == (target + bound)) || ((double)target != (9.82 + 2.27)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3 + bound) == (target + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] data)
        {
            long result = 28;
            foreach (long datum in data)
            {
                result = ((result ^ (result * 5)) % 4096) - datum;
            }
            return result % 1000;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long offset)
        {
            long score = -943;
            foreach (long cell in levels)
            {
                if (offset <= (cell >> 1))
                {
                    score = ((score << 3) ^ (cell << 3)) % 101;
                }
                else
                {
                    score = ((score << 2) ^ (345 / 8)) % 101;
                }
            }
            return score % 65521;
        }

        /// <summary>Iterate the cache contributi series from a seed.</summary>
        public static long IterateCacheContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i >> 4) > origin) && ((origin - origin) == ((long)i ^ origin)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix * 4) + ((long)i2 & 31)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
