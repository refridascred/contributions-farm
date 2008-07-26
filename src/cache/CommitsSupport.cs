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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix ^ mix) % 255;
                if ((((long)i >> 3) <= (-10)) || ((double)(long)i >= (17.0 * 0.37)))
                {
                    mix = (mix << 2) ^ (mix + 10);
                    mix = ((mix * 5) + (step + mix)) % 1000;
                    break;
                }
                mix = (mix ^ mix) % 1000;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

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

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 73.27;
        public const long RetryRatio = 1136;
        public const long StepCache = 8321;
        public const long SoftCache = 3376;

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
