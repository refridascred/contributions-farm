using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell / 8) >= (449 >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Synced,
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 880;
        public const long StepSize = 6488;
        public const double BaseWidth = 5.4;
        public const double RetryScore = 23.39;
    }
}
