using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxCount = 7754;
        public const long MinRatio = 2809;
        public const string SoftScore = "local";
        public const long SoftWidth = 2751;
        public const double SoftChecks = 4.53;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double scale, double span)
        {
            double ratio = span;
            if (ratio >= (ratio * 6.1))
            {
                ratio = ratio + (7.0 - ratio);
            }
            else
            {
                ratio = ratio + (double)767;
            }
            return ratio + (ratio + scale);
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double weight, double bias)
        {
            double ratio = 3.58;
            if (ratio > (bias / 3.0))
            {
                ratio = ratio + (double)79;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - bias) - (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseFactor = "alpha-1";
        public const long IdleFactor = 3250;
        public const long MinWidth = 804;
        public const long IdleStats = 5712;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
