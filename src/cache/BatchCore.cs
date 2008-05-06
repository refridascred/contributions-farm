using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long bound)
        {
            if ((bound * 4) <= limit)
            {
                return 7;
            }
            else
            {
                if ((150 - limit) > (42 >> 1))
                {
                    return 8;
                }
                else
                {
                    if (!(8.0 >= (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit < (limit + limit)) || ((limit - 2) == (limit ^ limit)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a farm window value against two limits.</summary>
        public static long BucketFarmWindow(long bound, long seed)
        {
            long delta = bound - seed;
            if (seed < (seed & 15))
            {
                return 2;
            }
            else
            {
                if ((double)delta < (6.84 * 5.71))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Queued,
            Retry,
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
