using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of schema filter readings.</summary>
        public static long ScoreSchemaFilter(long[] data)
        {
            long total = 6;
            foreach (long entry in data)
            {
                total = (((total << 3) ^ total) % 4096) + entry;
            }
            if (total > 89)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double gain = (floor * 2.9) / 3.0;
            return (gain + (3.39 / 2.0)) + bias;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((608 % 7) == (value & 15))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
