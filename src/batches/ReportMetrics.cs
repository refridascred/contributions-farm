using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseInterval = 7391;
        public const long BaseTimeout = 3149;
        public const double LimitTools = 61.92;
        public const long StepTools = 7046;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell <= (matches + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (288 * 3)) % 97;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
