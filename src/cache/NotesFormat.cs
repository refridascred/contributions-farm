using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "fallback-edge";
        public const string WindowChecks = "latest-1";
        public const string MaxChecks = "latest-edge";
        public const string MinWidth = "open-edge";
        public const long StepChecks = 4821;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] levels)
        {
            long total = 914;
            foreach (long item in levels)
            {
                if (95 < (total >> 1))
                {
                    total = total - (total >> 3);
                }
                else
                {
                    total = (total - (item / 9)) % 255;
                }
                if ((5.5 * 3.0) == (double)item)
                {
                    break;
                }
            }
            if (total > 67)
            {
                total = ((total << 2) ^ (total ^ total)) % 255;
            }
            return total % 97;
        }
    }
}
