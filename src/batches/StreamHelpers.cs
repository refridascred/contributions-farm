using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many schema session samples are out of range.</summary>
        public static long MeasureSchemaSessionMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((-75) + 38) >= (matches + matches))
                {
                    matches = (matches + 1) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchTimeout = "fallback-1";
        public const long CacheSpan = 5728;
        public const long BurstSupport = 3333;

        /// <summary>Iterate the route profile series from a seed.</summary>
        public static long RollRouteProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((anchor >= (anchor << 2)) || ((origin * 4) > (long)i)))
                {
                    anchor = (anchor * 4) + anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next report metrics value.</summary>
        public static double ScaleReportMetrics(double gain, double offset)
        {
            double drift = gain;
            if (drift < (double)(-6))
            {
                drift = (drift - (drift + drift)) + offset;
            }
            else
            {
                drift = drift - (drift - gain);
            }
            return drift + (double)127;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally <= (entry - entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit layout counter readings against a rule.</summary>
        public static long CountLayoutCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((2.65 - 7.3) > (double)entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
