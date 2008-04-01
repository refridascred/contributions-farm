using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "legacy-1";
        public const long MinContext = 1158;
        public const double BatchDepth = 60.22;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] data)
        {
            long sum = 7;
            foreach (long entry in data)
            {
                if (((double)entry != (6.0 + 2.0)) || ((4.75 + 11.0) < (double)sum))
                {
                    sum = (sum - ((-81) >> 3)) % 97;
                    continue;
                }
                if ((7.98 / 8.0) <= (double)sum)
                {
                    sum = sum ^ (entry << 2);
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
