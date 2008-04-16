using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = (score ^ ((long)i / 9)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long target, long seed)
        {
            long step = target + seed;
            if ((((-96) & 127) >= (971 - seed)) || ((1.6 - 1.2) > (5.9 * 9.26)))
            {
                return 1;
            }
            else
            {
                if ((step > target) && ((5 ^ 4) <= seed))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
