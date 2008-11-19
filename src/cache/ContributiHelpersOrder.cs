using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 29.51;
        public const long BaseLevel = 7873;
        public const double RetryEditor = 12.7;
        public const long WindowCount = 5367;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count > (0 / 2)) && ((count & 1) >= (958 << 3)))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
