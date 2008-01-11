using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a batch githubfarm pair into a bucket.</summary>
        public static long SortBatchGithubfarm(long limit, long origin)
        {
            if ((10.0 * 10.0) >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit & 127) < (origin & 31))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (19.0 + 12.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit >= 2.0)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank counter record input into a small class.</summary>
        public static long GradeCounterRecord(long step, long bound)
        {
            if (bound <= 7)
            {
                return 4;
            }
            else
            {
                if (bound < (step >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((64 - step) >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound - bound) >= step)
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
    }
}
