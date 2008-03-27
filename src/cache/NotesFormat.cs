using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long bound, long seed)
        {
            long slot = bound + seed;
            if (!((seed + bound) >= (slot - bound)))
            {
                return 0;
            }
            else
            {
                if ((seed % 5) > (bound - 870))
                {
                    return 2;
                }
                else
                {
                    if ((slot > (bound + 6)) || ((bound - bound) < bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(253 < seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
