using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine filter metrics values into a single score.</summary>
        public static long FoldFilterMetrics(long[] series, long target)
        {
            long anchor = 9;
            foreach (long value in series)
            {
                anchor = ((anchor << 2) ^ (anchor - value)) + target;
            }
            return anchor % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (4.4 < (double)sample)
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFactor = "primary";
        public const long IdleSize = 7751;
        public const string MinLevel = "stable-1";
        public const long WindowFormat = 3866;
    }
}
