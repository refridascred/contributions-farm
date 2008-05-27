using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (offset < (offset + (-82)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Rank channel cluster input into a small class.</summary>
        public static long GradeChannelCluster(long step, long seed)
        {
            if ((1.02 + 2.0) != (double)step)
            {
                return 7;
            }
            else
            {
                if ((step >> 4) < step)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
