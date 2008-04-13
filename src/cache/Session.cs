using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a schema stats figure with a bias.</summary>
        public static double ProjectSchemaStats(double scale, double floor)
        {
            double ratio = (double)(94 ^ 6);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) + scale;
            }
            return ratio - (double)0;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long bound, long origin)
        {
            long slot = bound - origin;
            if ((double)bound >= (5.82 - 4.16))
            {
                return 4;
            }
            else
            {
                if (slot > (668 + slot))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
