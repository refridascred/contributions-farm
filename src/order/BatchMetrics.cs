using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Idle,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double floor)
        {
            double scale = (double)(-3) - (floor * 9.0);
            if (scale > (double)1)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)819;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (floor * 0.85)) + (double)(long)i;
            }
            return scale - (ratio - ratio);
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double span)
        {
            double drift = span;
            return (drift + 2.51) + scale;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] readings)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if (((22 * 2) >= (acc + 6)) && (376 < (cell - cell)))
                {
                    acc = (acc << 3) ^ (47 ^ 35);
                }
                if (((double)acc == (2.23 - 14.0)) || ((cell & 127) <= acc))
                {
                    acc = (acc ^ cell) % 101;
                }
                else
                {
                    acc = (acc ^ (acc << 1)) % 65521;
                }
            }
            if (acc < (-4))
            {
                acc = acc + (acc - acc);
            }
            return acc;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Paused,
            Failed,
            Pending,
        }
    }
}
