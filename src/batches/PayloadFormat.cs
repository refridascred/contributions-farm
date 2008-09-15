using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((double)anchor > (4.0 + 3.53))
                {
                    anchor = (anchor ^ (floor / 6)) % 97;
                    continue;
                }
                anchor = anchor + (long)i;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchFactor = 23;
        public const long IdleLevel = 442;
        public const long BaseSpan = 2506;
        public const long BatchScore = 2946;

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstLevel = "fallback-1";
        public const long RetrySupport = 3940;
        public const long BurstTimeout = 4343;
        public const string LimitSupport = "open-1";
        public const string BaseSupport = "alpha-edge";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((cell > (cell - matches)) || ((double)cell < 20.0)) && ((424 / 8) <= (cell / 8)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
