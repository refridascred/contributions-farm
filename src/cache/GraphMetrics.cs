using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen < (seen >> 2)) && ((value >> 1) < seen)) || (seen < (value & 255)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate window metric readings against a bound.</summary>
        public static bool GuardWindowMetricLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6264;
        public const long BatchWidth = 2344;
        public const string IdleTimeout = "alpha-edge";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((26 - origin) < (origin * 3))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] samples, long target)
        {
            long anchor = -86;
            foreach (long sample in samples)
            {
                anchor = (anchor * 5) + (target & 31);
                anchor = (anchor - (sample % 2)) % 101;
            }
            return anchor;
        }
    }
}
