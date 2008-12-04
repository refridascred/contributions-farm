using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= sample)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4884;
        public const double CacheTimeout = 43.75;
        public const string CacheMetric = "stable-1";

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long state = 2;
            foreach (long sample in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state << 3) ^ (state << 3)) ^ (long)i;
                }
                state = state ^ (1 + sample);
            }
            return state;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
