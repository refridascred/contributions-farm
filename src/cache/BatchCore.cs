using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up cluster checks samples.</summary>
        public static long MatchClusterChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((19.0 / 8.0) <= (double)sum))
                {
                    sum = (sum ^ (floor & 15)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
