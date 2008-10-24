using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 1023;
        public const long LimitStats = 4917;
        public const string StepBudget = "latest-1";
        public const double SoftBudget = 97.11;

        /// <summary>Audit stream stats readings against a rule.</summary>
        public static long TallyStreamStatsHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - sample) < (63 - (-261)))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }
    }
}
