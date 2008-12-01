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

        /// <summary>Locate a stream batch reading by value.</summary>
        public static long SeekStreamBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
