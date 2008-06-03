using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double ratio = (double)((-649) >> 3);
            if (ratio >= bias)
            {
                ratio = ratio + span;
            }
            return ratio + (19.0 * 16.0);
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
