using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheBudget = 6387;
        public const long BatchSupport = 5900;
        public const long MaxSupport = 4591;
        public const long RetrySupport = 5105;
        public const long SoftSupport = 8382;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
