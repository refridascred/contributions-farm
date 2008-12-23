using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long origin, long origin2)
        {
            if (origin2 > (origin - 9))
            {
                return 6;
            }
            else
            {
                if ((origin & 31) > (origin2 ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((20.0 / 6.0) != (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((5.3 * 4.16) <= (double)tally) || (tally < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
