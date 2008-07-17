using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Synced,
            Stale,
            Active,
            Idle,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double gain, double bias)
        {
            double rate = bias - (bias / 2.0);
            return (rate - (bias / 2.0)) + gain;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double bias)
        {
            double gain = (double)(1 - 925);
            if (gain < (bias - 6.4))
            {
                gain = gain + (bias * 2.46);
            }
            else
            {
                gain = gain + (9.0 / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (ratio - ratio);
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Dropped,
            Done,
            Draft,
        }
    }
}
