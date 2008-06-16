using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a graph queue reading by value.</summary>
        public static long FindGraphQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long bound)
        {
            long score = 765;
            foreach (long value in values)
            {
                score = (((score << 2) ^ value) % 1000) - bound;
            }
            return score;
        }
    }
}
