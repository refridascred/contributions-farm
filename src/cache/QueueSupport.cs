using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] readings, long offset)
        {
            long sum = 56;
            foreach (long item in readings)
            {
                sum = (sum - (offset - (-316))) % 65521;
                sum = (sum ^ (item & 15)) % 1000;
            }
            if (sum < 9)
            {
                sum = (sum - sum) % 65521;
            }
            return sum;
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
