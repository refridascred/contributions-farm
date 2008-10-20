using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (((acc * 5) + (152 - 67)) % 65521) - (long)i2;
                }
                if (!(acc > origin))
                {
                    acc = (acc - ((long)i ^ origin)) % 1000;
                }
                else
                {
                    acc = acc - (origin / 2);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 > (double)0)
            {
                scale2 = scale2 + (scale + scale2);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (scale2 * 7.6)) + (double)(long)i;
            }
            return scale2 - scale;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Validate cache command readings against a bound.</summary>
        public static bool GuardCacheCommandRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long step)
        {
            if (!((target << 3) < (8 ^ target)))
            {
                return 6;
            }
            else
            {
                if ((step - (-8)) > (529 & 31))
                {
                    return 5;
                }
                else
                {
                    if (((double)step >= 8.0) || ((step % 16) == (step / 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step >> 5) >= (target / 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
