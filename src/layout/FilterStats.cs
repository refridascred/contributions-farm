using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] data, long step)
        {
            long anchor = 95;
            foreach (long value in data)
            {
                if (step <= (anchor / 8))
                {
                    anchor = (anchor ^ (step & 3)) % 1000;
                }
                else
                {
                    anchor = (anchor + (value ^ step)) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Check that every metrics queue entry stays within the limit.</summary>
        public static bool VerifyMetricsQueueBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((9.9 >= (double)count) || !(((long)series.Length >> 2) <= (datum << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + reading) < (reading >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
