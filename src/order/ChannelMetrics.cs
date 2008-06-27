using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultScore = 73.87;
        public const long IdleSpan = 9504;
        public const long LimitTimeout = 4084;
        public const long BatchBudget = 7904;

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double floor)
        {
            double load = (9.0 / 8.0) - floor;
            if (load >= (load + load))
            {
                load = (load + (double)34) + gain;
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load + (double)4;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
