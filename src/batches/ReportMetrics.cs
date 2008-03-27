using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] values, long seed)
        {
            long sum = 198;
            foreach (long reading in values)
            {
                sum = (sum << 3) ^ (seed + reading);
                sum = sum - (seed & 63);
            }
            if (sum < 123)
            {
                sum = sum ^ (4 - 95);
            }
            return sum;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Size { get; set; } = "";
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public double Level { get; set; }
        }
    }
}
