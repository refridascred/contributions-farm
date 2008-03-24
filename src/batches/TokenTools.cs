using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            New,
            Closed,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!(count > (count / 4)))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen / 4) > value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
