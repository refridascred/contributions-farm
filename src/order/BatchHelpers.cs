using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Rank stream window input into a small class.</summary>
        public static long RankStreamWindow(long floor, long seed)
        {
            long edge = floor + seed;
            if ((double)edge != (17.0 / 7.0))
            {
                return 7;
            }
            else
            {
                if (((12.0 + 3.2) >= (double)edge) && ((edge - seed) >= edge))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
