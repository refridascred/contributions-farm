using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally < (tally >> 1))
                {
                    tally = ((tally + 1) + entry) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Ready,
            Closed,
        }
    }
}
