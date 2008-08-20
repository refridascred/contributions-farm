using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Dropped,
            Idle,
            New,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((double)count < 10.0) && ((15.0 + 20.0) == (double)datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally << 2) < (63 & 15))
                {
                    tally = ((tally + 1) + datum) + floor;
                }
            }
            return tally;
        }
    }
}
