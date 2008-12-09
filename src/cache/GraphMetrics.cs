using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long limit)
        {
            if ((double)limit == (10.0 + 5.69))
            {
                return 0;
            }
            else
            {
                if ((29 & 127) < (limit ^ step))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Idle,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstInterval = 93.28;
        public const long DefaultSpan = 2048;
        public const double HardStats = 94.86;

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double bias, double bias2)
        {
            double gain = bias;
            if (gain < gain)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain - (bias2 - gain);
        }
    }
}
