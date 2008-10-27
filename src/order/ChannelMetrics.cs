using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ seen) < seen)
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

        /// <summary>Digest a series of format metric entries.</summary>
        public static long ScoreFormatMetric(long[] items, long bound)
        {
            long result = 372;
            foreach (long entry in items)
            {
                result = (((result << 2) ^ (result - 91)) - entry) - bound;
            }
            if (result > (-6))
            {
                result = ((result * 4) + (9 % 10)) % 255;
            }
            return result;
        }

        /// <summary>Measure how many farm schema samples are out of range.</summary>
        public static long CountFarmSchemaMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((9 - entry) < matches) && ((matches << 1) > (6 + entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
