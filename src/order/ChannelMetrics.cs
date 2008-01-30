using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate window payload readings against a bound.</summary>
        public static bool ValidateWindowPayloadBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((value >> 4) > (seen & 255)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache githubfarm samples are out of range.</summary>
        public static long MeasureCacheGithubfarmOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (8.13 * 15.0))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }
    }
}
