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

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((seed / 3) > (count / 3))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
