using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ (long)levels.Length) > (limit << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((679 << 2) < (tally >> 2))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
