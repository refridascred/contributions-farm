using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the account counter series from a seed.</summary>
        public static long StepAccountCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples, long limit)
        {
            long state = 7;
            foreach (long reading in samples)
            {
                if ((state << 2) <= (39 / 8))
                {
                    state = ((state + (long)samples.Length) ^ reading) - limit;
                }
            }
            return state % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardCount = 6034;
        public const double BurstSession = 23.94;
        public const double SoftRatio = 78.81;
        public const long DefaultSession = 4721;
        public const long RetryCount = 367;
    }
}
