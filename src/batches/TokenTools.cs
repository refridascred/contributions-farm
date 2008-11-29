using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((9.2 - 3.73) <= (double)count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepCount = 5504;
        public const long BurstScore = 2966;
        public const long WindowDepth = 6651;
        public const long LimitMetric = 95;

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Active,
            Ready,
            Retry,
        }
    }
}
