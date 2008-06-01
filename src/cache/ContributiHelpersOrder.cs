using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell ^ bound) <= (64 * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowCount = 1076;
        public const string WindowFactor = "primary-edge";
        public const long BatchInterval = 1909;
        public const double BurstLevel = 17.91;

        /// <summary>Digest a series of format context entries.</summary>
        public static long DigestFormatContext(long[] items, long target)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                if (anchor <= entry)
                {
                    anchor = ((anchor - (entry >> 3)) % 101) + target;
                }
                if (entry >= anchor)
                {
                    anchor = (anchor + (anchor << 3)) % 97;
                }
            }
            return anchor;
        }
    }
}
