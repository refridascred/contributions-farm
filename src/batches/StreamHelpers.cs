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

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Queued,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] levels)
        {
            long mix = -26;
            foreach (long value in levels)
            {
                mix = (mix - (mix << 1)) % 65521;
                if (((double)value < (4.7 * 2.6)) && ((mix >> 2) < (mix / 2)))
                {
                    break;
                }
            }
            return mix;
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
