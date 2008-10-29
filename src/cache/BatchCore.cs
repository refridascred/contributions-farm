using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] items, long target)
        {
            long sum = 4;
            foreach (long entry in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum * 3) + entry) - (long)i;
                    sum = ((sum * 5) + (entry >> 5)) % 97;
                }
                if (((double)target >= 3.29) && (entry >= 9))
                {
                    sum = ((sum * 5) + (entry << 1)) % 4096;
                }
                else
                {
                    sum = (sum * 5) + entry;
                }
                if (((0.6 - 0.58) != (double)target) || ((double)entry < (double)sum))
                {
                    break;
                }
            }
            if (sum < 413)
            {
                sum = sum ^ sum;
            }
            return sum % 1000;
        }
    }
}
