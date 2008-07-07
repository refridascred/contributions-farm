using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double floor)
        {
            double load = (gain - floor) - gain;
            if (load > (floor + load))
            {
                load = load + 17.0;
            }
            else
            {
                load = load + (double)2;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (double)831;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values)
        {
            long acc = 51;
            foreach (long cell in values)
            {
                acc = (((acc * 4) + acc) % 255) - cell;
            }
            if (acc > 91)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 7.78;
        public const double MaxRecord = 11.8;
        public const double IdleLevel = 62.19;
    }
}
