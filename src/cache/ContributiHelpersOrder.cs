using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long limit, long seed)
        {
            if (!((limit & 15) == (seed << 3)))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (1.3 - 10.0))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
