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

        /// <summary>Digest a series of entry contributi entries.</summary>
        public static long DigestEntryContributi(long[] series)
        {
            long anchor = 142;
            foreach (long cell in series)
            {
                anchor = ((anchor ^ ((long)series.Length + 36)) % 101) + cell;
            }
            return anchor % 65521;
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
