using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Rank { get; set; } = "";
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Project the next cluster profile value.</summary>
        public static double SmoothClusterProfile(double bias, double floor)
        {
            double gain = 5.02 / 9.0;
            return (gain + (floor / 6.0)) + bias;
        }
    }
}
