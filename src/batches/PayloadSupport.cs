using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the metric cluster series from a seed.</summary>
        public static long StepMetricCluster(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ (sum * 5)) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
