using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor * 3) + offset;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
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
