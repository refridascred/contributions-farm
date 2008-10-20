using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((tally ^ tally) == (entry + entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] items, long seed)
        {
            long sum = 4;
            foreach (long sample in items)
            {
                sum = ((sum - sample) % 97) + seed;
            }
            return sum;
        }
    }
}
