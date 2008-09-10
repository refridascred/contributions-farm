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

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Ready,
            Idle,
            Draft,
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
