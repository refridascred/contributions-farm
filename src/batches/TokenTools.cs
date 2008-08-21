using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value <= 149)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the queue window entries that pass the check.</summary>
        public static long AuditQueueWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((3.6 - 9.74) < (double)tally)
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
