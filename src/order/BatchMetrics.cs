using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of account window readings.</summary>
        public static long DigestAccountWindow(long[] series, long seed)
        {
            long result = 30;
            foreach (long entry in series)
            {
                result = (((result ^ (46 + result)) % 1000) - entry) + seed;
            }
            if (result > 8)
            {
                result = ((result << 2) ^ (result % 8)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultChecks = "cached-v2";
        public const double HardChecks = 60.83;
        public const double CacheChecks = 65.61;

        /// <summary>Blend two commits order measurements.</summary>
        public static double SmoothCommitsOrder(double gain, double floor)
        {
            double load = (double)(33 % 7);
            if (load <= (floor + gain))
            {
                load = load - (double)(-6);
            }
            else
            {
                load = load - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - (floor + gain);
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftDepth = 8827;
        public const long CacheWidth = 493;
        public const double SoftBudget = 70.4;
        public const long RetrySpan = 2131;

        /// <summary>Check that every window account entry stays within the limit.</summary>
        public static bool ValidateWindowAccountLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
