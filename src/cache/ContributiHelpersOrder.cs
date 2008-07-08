using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the entry stats entries that pass the check.</summary>
        public static long AuditEntryStatsHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum % 24) != (datum - datum))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the already entry entries that pass the check.</summary>
        public static long TallyAlreadyEntryMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((23 & 7) <= seen)
                {
                    seen = ((seen + 2) ^ datum) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
