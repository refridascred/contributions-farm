using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches & 31) <= matches)
                {
                    matches = ((matches + 3) ^ datum) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 5168;
        public const string SoftEditor = "open-edge";
        public const long BaseEditor = 6613;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
