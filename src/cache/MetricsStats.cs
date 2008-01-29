using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (219 >= ((long)samples.Length & 15))
                {
                    count = ((count + 1) + value) - limit;
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((39 / 2) < (step + step)))
                {
                    anchor = (anchor * 5) + (anchor % 60);
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value - seen) == (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
