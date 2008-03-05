using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long limit, long seed)
        {
            if (((8.0 + 9.31) >= (double)seed) && ((double)limit != (0.67 - 1.6)))
            {
                return 8;
            }
            else
            {
                if ((double)limit > (15.0 - 8.4))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Active,
            Closed,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            New,
            Idle,
        }

        /// <summary>Blend two cache counter measurements.</summary>
        public static double BlendCacheCounter(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + drift) - (double)(long)i) - span;
            }
            return drift + scale;
        }
    }
}
