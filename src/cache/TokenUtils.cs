using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next account tools value from a seed.</summary>
        public static long StepAccountTools(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = state + ((long)i & 31);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of context report readings.</summary>
        public static long OverlapContextReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
