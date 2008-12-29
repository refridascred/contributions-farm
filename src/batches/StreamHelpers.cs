using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Failed,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepLevel = 1206;
        public const double MaxRatio = 73.95;
        public const long BatchCommits = 5799;
        public const long WindowLevel = 3134;

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 5428;
        public const double IdleBudget = 31.66;
        public const long BatchTools = 8326;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two farm order measurements.</summary>
        public static double BlendFarmOrder(double bias, double bias2)
        {
            double drift = bias2 * 7.5;
            if (drift < (double)955)
            {
                drift = drift - (drift / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (bias - bias2);
        }
    }
}
