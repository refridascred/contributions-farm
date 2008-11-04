using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cache tools readings against a rule.</summary>
        public static long TallyCacheToolsHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading < (origin / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order metrics pair into a bucket.</summary>
        public static long GradeOrderMetrics(long floor, long origin)
        {
            long bound = floor ^ origin;
            if (((floor + 6) != (bound << 1)) && ((double)29 == (double)floor))
            {
                return 5;
            }
            else
            {
                if ((double)origin != (1.1 + 2.08))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound > 12.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin ^ 789) != (6 << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
