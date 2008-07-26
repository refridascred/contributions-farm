using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate commits metric readings against a bound.</summary>
        public static bool ValidateCommitsMetricBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit counter token readings against a rule.</summary>
        public static long CountCounterTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen + seen) < seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Check that every commits contributi entry stays within the limit.</summary>
        public static bool VerifyCommitsContributiLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Active,
            Pending,
            Done,
        }

        /// <summary>Measure how many cache support samples are out of range.</summary>
        public static long AuditCacheSupportGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((7.39 - 1.3) < (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (((anchor << 2) ^ floor) % 1000) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
