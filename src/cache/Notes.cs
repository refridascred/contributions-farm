using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long limit, long offset)
        {
            if ((968 & 7) > ((-12) - offset))
            {
                return 0;
            }
            else
            {
                if (!((6.9 + 13.0) == (double)limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit / 3) > (limit % 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count ^ 4) <= (seed + 3))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
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
