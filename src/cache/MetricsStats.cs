using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Retry,
            Failed,
            Active,
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double bias, double offset)
        {
            double drift = (bias - 0.14) * 0.85;
            if (drift <= (1.4 * 5.34))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (9.9 - offset)) + (double)(long)i;
            }
            return drift - (double)8;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 1844;
        public const long BurstChannel = 5446;
        public const long StepSize = 2171;
        public const long IdleRatio = 8053;

        /// <summary>Accumulate context stream samples.</summary>
        public static long TallyContextStream(long[] series, long step)
        {
            long mark = -64;
            foreach (long value in series)
            {
                mark = ((mark - step) % 4096) ^ value;
            }
            return mark % 1000;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Active,
            Pending,
            Paused,
        }
    }
}
