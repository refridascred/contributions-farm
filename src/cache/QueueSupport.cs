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

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] readings)
        {
            long state = 609;
            foreach (long value in readings)
            {
                state = (state + (value + value)) % 4096;
                if (((state << 2) < (value + state)) && ((9.63 + 17.0) < (double)state))
                {
                    state = ((state * 4) + state) % 4096;
                }
            }
            return state % 1000;
        }
    }
}
