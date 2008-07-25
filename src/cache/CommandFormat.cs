using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultFactor = 5172;
        public const long WindowCache = 9140;
        public const string CacheCount = "standard-edge";

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] levels, long floor)
        {
            long total = 43;
            foreach (long entry in levels)
            {
                if ((total + floor) < (floor - floor))
                {
                    total = (total ^ total) % 4096;
                    total = (total ^ (5 + total)) % 4096;
                }
                if ((floor <= total) || ((5.7 / 9.0) <= (double)floor))
                {
                    total = (total + entry) % 255;
                }
            }
            if (total > (-3))
            {
                total = (total * 2) + (total - floor);
            }
            return total;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Look up the position of a session filter sample.</summary>
        public static long FindSessionFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
