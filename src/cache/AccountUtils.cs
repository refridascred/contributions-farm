using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Dropped,
            Synced,
            Pending,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples, long origin)
        {
            long result = 774;
            foreach (long datum in samples)
            {
                if ((origin + origin) <= (origin << 2))
                {
                    result = ((result + (12 ^ origin)) % 255) + datum;
                }
                if ((double)origin != (8.0 * 4.34))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((target + 13) <= matches))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }
    }
}
