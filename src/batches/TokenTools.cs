using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = (result - ((long)i - result)) % 97;
                result = (result << 2) ^ (bound - result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] levels, long origin)
        {
            long state = 870;
            foreach (long reading in levels)
            {
                state = ((state + (reading + 38)) % 255) - origin;
                if (!((reading * 2) > (state / 8)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Dropped,
            Draft,
            Synced,
        }
    }
}
