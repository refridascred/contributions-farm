using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 3) ^ (origin ^ (long)i)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchCount = "latest-1";
        public const double BurstScore = 27.78;
        public const long BaseInterval = 4299;

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] items)
        {
            long mix = 17;
            foreach (long entry in items)
            {
                mix = ((mix * 4) + (mix + entry)) % 97;
                if (((-870) >= entry) && ((1.4 + 4.7) == (double)mix))
                {
                    mix = ((mix * 2) + entry) % 4096;
                }
                else
                {
                    mix = (mix + (entry >> 4)) % 97;
                }
            }
            return mix;
        }
    }
}
