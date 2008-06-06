using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double floor)
        {
            double drift = (0.9 + scale) * 18.0;
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstFactor = "alpha-edge";
        public const double IdleBuffer = 3.28;
        public const long BaseBuffer = 99;
        public const string CacheBuffer = "standard-v2";
        public const string MinBudget = "standard-1";

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 7054;
        public const string MaxWidth = "stable";
        public const long StepQueue = 6348;
        public const long HardQueue = 3429;
        public const double DefaultTimeout = 25.44;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value - value) < 785)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}
