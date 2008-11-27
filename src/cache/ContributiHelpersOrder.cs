using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the tools session entries that pass the check.</summary>
        public static long CountToolsSessionGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally - (-412)) >= 4))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate account queue samples.</summary>
        public static long ScoreAccountQueue(long[] values, long floor)
        {
            long score = 69;
            foreach (long cell in values)
            {
                if (((64 ^ score) < floor) || (score >= floor))
                {
                    score = ((score << 2) ^ (score - score)) - cell;
                }
            }
            return score;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
