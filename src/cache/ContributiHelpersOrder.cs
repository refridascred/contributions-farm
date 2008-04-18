using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 4260;
        public const long CacheSupport = 5502;
        public const long MaxSupport = 4608;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheLevel = 3787;
        public const long SoftWidth = 8280;
        public const long IdleTimeout = 7472;
        public const double HardCommand = 49.71;

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
