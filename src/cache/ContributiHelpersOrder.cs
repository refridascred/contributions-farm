using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 548;
        public const long BatchSupport = 780;
        public const string MaxSupport = "latest";
        public const long BurstSupport = 848;
        public const double IdleSupport = 81.02;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Paused,
            Synced,
            Closed,
            New,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
