using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double bias = gain;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - (floor + floor);
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Queued,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double ratio, double offset)
        {
            double load = (ratio + ratio) + (double)9;
            if (load > offset)
            {
                load = load - (load / 9.0);
            }
            else
            {
                load = load - (double)9;
            }
            return load - 7.05;
        }
    }
}
