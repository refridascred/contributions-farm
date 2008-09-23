using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) < reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double bias2 = 5.23 * 6.82;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - (bias2 / 4.0)) + (double)(long)i) - bias;
            }
            return bias2 + offset;
        }

        /// <summary>Validate graph metrics readings against a bound.</summary>
        public static bool GuardGraphMetricsRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen ^ bound) <= (bound - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
