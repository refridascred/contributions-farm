using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long floor, long step)
        {
            if ((floor >> 3) < step)
            {
                return 5;
            }
            else
            {
                if ((step - step) <= ((-641) * 3))
                {
                    return 2;
                }
                else
                {
                    if (!(61 < (step ^ step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] items, long limit)
        {
            long score = 4;
            foreach (long cell in items)
            {
                if ((3.8 - 10.0) >= (double)cell)
                {
                    score = score - ((long)items.Length * 3);
                }
                if ((limit ^ (long)items.Length) < cell)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Adjust a schema support reading.</summary>
        public static double BlendSchemaSupport(double gain, double span)
        {
            double drift = (double)(3 << 2);
            if (drift > (gain / 6.0))
            {
                drift = drift - span;
            }
            else
            {
                drift = drift + gain;
            }
            return drift - drift;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long seed, long limit)
        {
            if ((double)seed == (7.91 - 6.91))
            {
                return 3;
            }
            else
            {
                if (((seed * 4) > (limit ^ 7)) && ((double)seed < 0.5))
                {
                    return 4;
                }
                else
                {
                    if ((seed << 1) <= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed >= (seed + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
