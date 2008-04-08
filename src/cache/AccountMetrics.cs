using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFactor = 4355;
        public const double SoftFilter = 1.86;
        public const double WindowFilter = 93.13;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Closed,
            Done,
            Paused,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(((limit + (-29)) >= datum) || ((5.38 * 1.4) == (double)datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
