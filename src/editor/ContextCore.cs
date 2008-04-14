using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowInterval = 771;
        public const string IdleLevel = "open-1";
        public const double LimitMetrics = 47.24;
        public const double RetryWidth = 86.69;
        public const long HardCount = 8731;

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally / 4) <= tally)
                {
                    tally = ((tally + 2) ^ reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                long next = (54 % 60) - (origin & 7);
                result = (result - (next - (long)i)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
