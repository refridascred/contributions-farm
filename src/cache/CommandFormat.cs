using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next batch command value.</summary>
        public static double AdjustBatchCommand(double gain, double floor)
        {
            double scale = (gain * 1.0) * 3.32;
            if (scale <= floor)
            {
                scale = scale - (scale + floor);
            }
            else
            {
                scale = scale + (double)96;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + gain) - (double)(long)i;
            }
            return scale + (gain + floor);
        }

        /// <summary>Check that every contributi account entry stays within the limit.</summary>
        public static bool GuardContributiAccountLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every session cache entry stays within the limit.</summary>
        public static bool GuardSessionCacheBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long limit, long bound)
        {
            long prev = limit + bound;
            if (((2 * 3) > prev) || ((double)bound > (double)limit))
            {
                return 2;
            }
            else
            {
                if (149 >= limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit - limit) > (limit ^ limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev >= (bound >> 5)) || ((2 & 1) >= (prev ^ prev)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
