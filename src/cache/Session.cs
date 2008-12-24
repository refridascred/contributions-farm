using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double floor)
        {
            double drift = (double)(35 + 5);
            if (drift > (drift + 3.96))
            {
                drift = ((drift - (13.0 * 2.08)) - ratio) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift + drift)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 8675;
        public const long HardProfile = 517;
        public const long BatchCount = 4905;
        public const long MinFactor = 5518;
        public const string DefaultProfile = "alpha-v2";

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Score { get; set; } = "";
            public double Weight { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
