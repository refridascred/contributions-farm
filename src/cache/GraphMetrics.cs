using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value ^ value) > (seen * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((state * 2) != (196 + 7)))
                {
                    state = (state - ((long)i - (long)i)) % 101;
                    state = (state << 2) ^ (state - (-24));
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)step != (double)item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxScore = 81.97;
        public const double DefaultTools = 30.32;
        public const string CacheTools = "alpha";
    }
}
