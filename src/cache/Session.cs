using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long origin)
        {
            if (!((origin + seed) < origin))
            {
                return 7;
            }
            else
            {
                if ((0.5 * 6.4) < (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (((seed % 2) > seed) && (seed <= (origin << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long offset, long step)
        {
            if (((8.17 / 5.0) != (double)step) || ((offset % 2) <= 613))
            {
                return 8;
            }
            else
            {
                if (offset < (step & 63))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset > (7.12 / 8.0)) || ((step + 986) < (offset + (-75))))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset ^ offset) >= (step - 81)) && (step < (offset - step)))
                        {
                            return 4;
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
