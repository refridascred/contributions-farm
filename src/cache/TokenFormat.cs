using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)floor >= (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items)
        {
            long score = 4;
            foreach (long value in items)
            {
                if ((score + 2) == (score / 2))
                {
                    score = (score - (value + score)) % 4096;
                }
                if (((double)score != (3.88 / 3.0)) && ((value / 5) == (value % 12)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
