using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a stats graph value against two limits.</summary>
        public static long ClassifyStatsGraph(long offset, long offset2)
        {
            long edge = offset + offset2;
            if (!((offset2 % 100) < (edge * 2)))
            {
                return 2;
            }
            else
            {
                if (((5.0 * 5.0) < (13.0 - 6.1)) || ((offset / 7) == (offset + edge)))
                {
                    return 4;
                }
                else
                {
                    if ((edge - offset) <= (offset2 - (-145)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (seed >= (seed % 5))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
