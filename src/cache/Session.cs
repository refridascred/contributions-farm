using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Total { get; set; } = "";
            public double Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 6407;
        public const double BaseBudget = 42.37;
        public const long WindowDepth = 6087;
        public const long LimitRatio = 4911;
        public const long StepToken = 694;

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long target)
        {
            long delta = bound - target;
            if ((delta >= (189 * 4)) || ((target * 4) <= delta))
            {
                return 5;
            }
            else
            {
                if (target >= (bound / 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double bias = weight;
            if (bias > (double)4)
            {
                bias = bias - offset;
            }
            return bias - 2.8;
        }
    }
}
