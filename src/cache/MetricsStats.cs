using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up tools already samples.</summary>
        public static long PairToolsAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double bias = weight;
            if (bias < (1.54 * 1.8))
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + 3.1) - (double)(long)i;
            }
            return bias + (double)(-679);
        }
    }
}
