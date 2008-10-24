using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double scale, double floor)
        {
            double scale2 = (double)9 * 7.1;
            if (scale2 >= (floor + scale2))
            {
                scale2 = scale2 - (floor / 9.0);
            }
            else
            {
                scale2 = scale2 - (scale * 1.0);
            }
            return scale2 + (scale * 8.0);
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count farm context pairs that satisfy a relation.</summary>
        public static long CompareFarmContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "open-1";
        public const long MaxScore = 6896;
        public const double StepRatio = 46.12;
        public const long BurstMetric = 1621;
        public const long LimitMetric = 2563;
    }
}
