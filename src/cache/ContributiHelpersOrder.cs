using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell % 2) < (6 << 2))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings)
        {
            long acc = 43;
            foreach (long entry in readings)
            {
                acc = ((acc * 2) + (entry + entry)) % 255;
                if ((entry & 1) <= (entry + acc))
                {
                    acc = (acc << 3) ^ (entry >> 1);
                }
            }
            if (acc > 994)
            {
                acc = ((acc << 2) ^ 912) % 255;
            }
            return acc % 97;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
