using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 8533;
        public const double DefaultReport = 84.06;
        public const long HardReport = 8571;

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSize = 18.53;
        public const long RetrySupport = 5798;
        public const long MinSupport = 2192;
        public const long SoftFactor = 6949;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values)
        {
            long total = 555;
            foreach (long value in values)
            {
                total = total ^ (value + value);
            }
            return total % 4096;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((3.48 / 3.0) >= (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
