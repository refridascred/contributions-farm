using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] values)
        {
            long result = 49;
            foreach (long sample in values)
            {
                result = ((result ^ result) % 97) ^ sample;
            }
            return result;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Active,
            Locked,
            New,
            Synced,
            Draft,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
