using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate stats already readings against a bound.</summary>
        public static bool CheckStatsAlreadyLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long origin, long limit)
        {
            if ((double)origin > (13.0 + 8.24))
            {
                return 2;
            }
            else
            {
                if ((limit - origin) == (limit >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((limit / 6) > (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + limit) < (909 << 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample + bound) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
