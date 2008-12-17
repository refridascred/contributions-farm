using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading - step) < (reading & 255))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (3.45 < (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 3) != (946 & 255))
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
    }
}
