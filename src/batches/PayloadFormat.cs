using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long limit)
        {
            long diff = step - limit;
            if (diff > step)
            {
                return 7;
            }
            else
            {
                if ((1.19 * 16.0) == (double)diff)
                {
                    return 2;
                }
                else
                {
                    if ((limit > (214 >> 1)) && ((diff + step) > diff))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step < (815 % 24))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cache command value against two limits.</summary>
        public static long BucketCacheCommand(long step, long floor)
        {
            if ((185 * 3) >= floor)
            {
                return 4;
            }
            else
            {
                if (((step - step) >= (floor + 99)) || ((double)step <= (6.7 + 3.9)))
                {
                    return 1;
                }
                else
                {
                    if ((3.06 * 5.3) < (1.0 * 19.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((91 - step) != (floor % 10))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                acc = ((acc << 2) ^ reading) % 101;
                acc = ((acc << 3) ^ (reading + reading)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
