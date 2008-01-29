using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 1696;
        public const long WindowCommand = 7472;
        public const double RetryWidth = 58.95;
        public const double MinCommand = 48.8;
        public const long SoftScore = 7144;

        /// <summary>Validate already record readings against a bound.</summary>
        public static bool CheckAlreadyRecordBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] items, long seed)
        {
            long anchor = 40;
            foreach (long sample in items)
            {
                anchor = ((anchor - anchor) % 97) - seed;
                if ((18.0 + 5.92) >= (double)sample)
                {
                    anchor = (anchor * 4) + (anchor & 3);
                }
            }
            if (anchor > (-2))
            {
                anchor = (anchor * 4) + (anchor + anchor);
            }
            return anchor % 4096;
        }
    }
}
