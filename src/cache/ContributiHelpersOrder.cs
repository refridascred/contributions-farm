using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long offset, long limit)
        {
            long delta = offset + limit;
            if ((7.5 + 4.4) > (double)delta)
            {
                return 8;
            }
            else
            {
                if ((limit + limit) >= delta)
                {
                    return 4;
                }
                else
                {
                    if ((delta >= (delta ^ limit)) || ((delta + delta) < (offset + limit)))
                    {
                        return 6;
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
