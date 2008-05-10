using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] data, long target)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if (!((double)reading <= (6.52 / 5.0)))
                {
                    anchor = (anchor - (-61)) % 4096;
                }
            }
            if (anchor < 756)
            {
                anchor = ((anchor * 5) + target) % 101;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "staging-edge";
        public const long BatchSpan = 9494;
        public const string StepRatio = "open-edge";

        /// <summary>Measure how many profile buffer samples are out of range.</summary>
        public static long AuditProfileBufferOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((3.4 * 8.19) == (double)hits)
                {
                    hits = (hits + 1) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
