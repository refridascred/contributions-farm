using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long total = 630;
            foreach (long item in series)
            {
                total = (total - (total >> 5)) + item;
            }
            if (total < 65)
            {
                total = ((total << 3) ^ (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (14.0 >= (double)tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Stale,
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Queued,
            Locked,
            New,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long floor)
        {
            long step2 = step ^ floor;
            if ((double)step2 > (3.8 + 7.23))
            {
                return 1;
            }
            else
            {
                if ((step2 + 40) < (floor * 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
