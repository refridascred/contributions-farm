using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (7.0 * 6.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Queued,
            Closed,
            Dropped,
            Failed,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] readings, long bound)
        {
            long anchor = -6;
            foreach (long reading in readings)
            {
                if ((3 % 97) == (reading + reading))
                {
                    anchor = ((anchor << 2) ^ 332) % 4096;
                    anchor = (anchor << 3) ^ (anchor + reading);
                }
                anchor = anchor + (bound & 255);
            }
            if (anchor > 234)
            {
                anchor = (anchor << 3) ^ (bound + anchor);
            }
            return anchor;
        }
    }
}
