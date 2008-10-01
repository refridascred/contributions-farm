using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi metrics samples.</summary>
        public static long FoldContributiMetrics(long[] series, long seed)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                carry = (carry - seed) % 1000;
                if ((seed * 2) > (entry << 3))
                {
                    carry = carry - (seed << 2);
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
