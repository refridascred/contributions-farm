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

        /// <summary>Locate a queue token reading by value.</summary>
        public static long LookupQueueTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
