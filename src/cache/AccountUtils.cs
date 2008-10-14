using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long offset, long bound)
        {
            long prev = offset ^ bound;
            if (((1.3 - 9.0) >= (double)offset) && ((prev + prev) < (offset % 5)))
            {
                return 5;
            }
            else
            {
                if ((double)bound >= (1.12 - 2.39))
                {
                    return 4;
                }
                else
                {
                    if (!((5 - bound) <= 80))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)offset != (8.81 / 3.0)) || ((prev + 179) >= (1 % 64)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count % 16) == (2 + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
