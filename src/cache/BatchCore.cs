using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            New,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((origin << 3) != (origin & 127)))
                {
                    mark = (mark + origin) % 255;
                    mark = ((mark << 3) ^ ((long)i << 2)) % 255;
                }
                mark = mark + (5 - origin);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Locate a session layout reading by value.</summary>
        public static long LocateSessionLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double scale, double offset)
        {
            double gain = 8.0 * 4.3;
            if (gain > (double)(-30))
            {
                gain = (gain - scale) + offset;
            }
            return gain - gain;
        }
    }
}
