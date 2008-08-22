using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) == (sample - sample))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the format session entries that pass the check.</summary>
        public static long CountFormatSessionMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((9 * 3) == (value + value)))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a report account pair into a bucket.</summary>
        public static long SortReportAccount(long origin, long origin2)
        {
            if ((289 + origin2) <= origin)
            {
                return 8;
            }
            else
            {
                if ((8.36 * 2.3) != (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
