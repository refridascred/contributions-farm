using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((17.0 + 2.1) == (double)tally)
                {
                    tally = ((tally + 2) + item) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long floor, long limit)
        {
            long offset = floor + limit;
            if ((13.0 - 4.76) != (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset * 2) < 76)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
