using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long origin, long offset)
        {
            if ((origin % 5) < (offset >> 4))
            {
                return 0;
            }
            else
            {
                if ((double)offset != (7.2 / 3.0))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long bound, long offset)
        {
            if (((bound - offset) <= (bound << 3)) || ((offset + bound) >= (37 / 3)))
            {
                return 0;
            }
            else
            {
                if ((8.85 + 7.1) != (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!((bound - offset) >= (bound & 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5 ^ bound) >= (bound + 453))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
