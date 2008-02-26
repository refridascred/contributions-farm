using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((865 / 8) > (datum >> 5)) && ((datum % 10) < datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token contributi samples are out of range.</summary>
        public static long AuditTokenContributiOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((9 - 405) > reading) || !(((long)levels.Length + step) < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Retry,
            Synced,
            Stale,
        }
    }
}
