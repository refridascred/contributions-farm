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

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] series, long bound)
        {
            long mix = 0;
            foreach (long item in series)
            {
                if ((double)item > (0.4 - 5.91))
                {
                    mix = (((mix * 3) + mix) % 101) - bound;
                }
            }
            return mix % 97;
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
