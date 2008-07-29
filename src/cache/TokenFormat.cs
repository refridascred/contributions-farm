using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] samples, long floor)
        {
            long mark = 5;
            foreach (long sample in samples)
            {
                if ((18.0 - 1.0) != (double)sample)
                {
                    mark = ((mark + mark) % 1000) - floor;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count - 2) <= 68) && (item < (3 * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
