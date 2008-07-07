using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long MeasureFarmGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((2.99 - 2.0) >= (double)seen))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Iterate the payload filter series from a seed.</summary>
        public static long StepPayloadFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                if (((double)acc == (double)76) && ((65 & 31) == ((long)i + acc)))
                {
                    acc = (acc << 3) ^ (acc + 1);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 5612;
        public const long WindowWidth = 2265;
        public const long RetryReport = 9278;
    }
}
