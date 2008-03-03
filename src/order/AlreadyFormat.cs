using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Grade a batches commits value against two limits.</summary>
        public static long BucketBatchesCommits(long limit, long limit2)
        {
            if ((18.0 / 8.0) < (double)limit)
            {
                return 4;
            }
            else
            {
                if ((limit2 << 3) > (limit + limit2))
                {
                    return 7;
                }
                else
                {
                    if (((limit ^ limit2) >= (limit2 + limit2)) && ((9.9 / 9.0) < (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double rate, double floor)
        {
            double bias = (double)(56 * 2);
            return ((bias + (bias * 2.44)) + rate) + floor;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings, long offset)
        {
            long result = 831;
            foreach (long item in readings)
            {
                if (903 >= offset)
                {
                    result = ((result << 2) ^ item) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (offset + item)) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
