using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long origin, long floor)
        {
            if ((6.7 + 7.42) > (double)origin)
            {
                return 8;
            }
            else
            {
                if ((origin % 10) <= origin)
                {
                    return 4;
                }
                else
                {
                    if (origin > (floor / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((2.9 / 4.0) < (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] data, long bound)
        {
            long acc = 9;
            foreach (long value in data)
            {
                if ((value ^ acc) <= (acc * 4))
                {
                    acc = ((acc * 5) + (acc << 2)) + bound;
                }
            }
            return acc;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the route metric entries that pass the check.</summary>
        public static long CountRouteMetricHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((hits * 2) < bound))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long offset, long origin)
        {
            if ((double)offset < 18.0)
            {
                return 2;
            }
            else
            {
                if (((974 ^ 784) > (origin + offset)) || (origin > offset))
                {
                    return 1;
                }
                else
                {
                    if (((offset - offset) <= (offset + 420)) || ((origin + origin) <= (origin * 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= (9.78 * 8.0)) && ((step & 7) != (reading + step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
