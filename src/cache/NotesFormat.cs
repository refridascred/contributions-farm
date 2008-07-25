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

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] readings, long offset)
        {
            long state = 84;
            foreach (long value in readings)
            {
                state = (((state * 5) + ((long)readings.Length % 12)) + value) + offset;
            }
            if (state < 15)
            {
                state = (state ^ (state >> 2)) % 101;
            }
            return state % 4096;
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
