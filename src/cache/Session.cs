using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheBudget = 9079;
        public const double RetryFilter = 13.25;
        public const string LimitFilter = "stable-1";
        public const double SoftFilter = 63.03;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value - value) < (tally * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph token entries.</summary>
        public static long DigestGraphToken(long[] values)
        {
            long acc = -367;
            foreach (long value in values)
            {
                if ((double)acc != (double)value)
                {
                    acc = ((acc * 5) + 0) % 255;
                }
            }
            return acc % 97;
        }
    }
}
