using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank queue channel input into a small class.</summary>
        public static long BucketQueueChannel(long target, long limit)
        {
            long step = target ^ limit;
            if ((2.5 - 0.7) <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((3.0 / 4.0) == (double)target)
                {
                    return 6;
                }
                else
                {
                    if (((4.0 + 14.0) < (double)limit) && ((double)step < (12.0 * 6.8)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank stream metric input into a small class.</summary>
        public static long ClassifyStreamMetric(long limit, long origin)
        {
            if ((origin ^ 803) < (origin << 2))
            {
                return 5;
            }
            else
            {
                if ((origin & 3) <= (limit - limit))
                {
                    return 1;
                }
                else
                {
                    if (limit > (limit + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit == (3.0 + 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 2) ^ (target ^ 0)) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
