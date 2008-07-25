using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBudget = 4328;
        public const long IdleScore = 5954;
        public const long MaxCount = 8151;
        public const long StepBatches = 3168;

        /// <summary>Validate stats command readings against a bound.</summary>
        public static bool VerifyStatsCommandRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next tools stats value.</summary>
        public static double AdjustToolsStats(double bias, double bias2)
        {
            double load = (double)(-29) * 8.2;
            if (load <= (bias2 - load))
            {
                load = (load + (double)5) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load * 17.0)) - (double)(long)i;
            }
            return load - (bias2 - bias2);
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double drift = (double)596 - (bias / 7.0);
            if (drift < (double)8)
            {
                drift = (drift + (drift * 6.0)) - bias2;
            }
            return drift - (8.35 / 8.0);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
