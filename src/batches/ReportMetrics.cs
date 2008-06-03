using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (4 / 9)) % 65521;
                if (((938 ^ seed) <= (seed % 60)) || (8.5 >= (double)total))
                {
                    total = total + (seed * 3);
                }
                else
                {
                    total = (total - 1) % 4096;
                }
                total = total + total;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
