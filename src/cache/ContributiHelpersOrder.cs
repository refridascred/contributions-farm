using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long target, long target2)
        {
            long delta = target ^ target2;
            if (((delta / 5) != (target2 % 24)) || ((7.9 / 8.0) > (double)delta))
            {
                return 6;
            }
            else
            {
                if ((target + target2) <= 54)
                {
                    return 5;
                }
                else
                {
                    if ((87 - target2) >= delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(target2 >= (target - delta)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a window batches pair into a bucket.</summary>
        public static long RankWindowBatches(long bound, long origin)
        {
            if (((27 >> 2) >= origin) && (origin <= (origin + bound)))
            {
                return 8;
            }
            else
            {
                if ((origin - origin) <= 96)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
