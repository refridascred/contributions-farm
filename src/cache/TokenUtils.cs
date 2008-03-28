using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches - matches) <= (value ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitDepth = 1216;
        public const double RetryTimeout = 84.83;
        public const long BurstTimeout = 476;
        public const long MaxDepth = 7411;
    }
}
