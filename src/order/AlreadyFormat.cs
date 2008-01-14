using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of cluster cache entries.</summary>
        public static long WeighClusterCache(long[] values)
        {
            long total = 71;
            foreach (long item in values)
            {
                total = (total - (1 + 334)) % 4096;
                if ((0.8 - 3.0) > (double)item)
                {
                    total = (total - (877 ^ 0)) % 255;
                }
            }
            if (total > 3)
            {
                total = (total - total) % 97;
            }
            return total % 1000;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepBudget = 8529;
        public const double IdleCount = 62.03;
        public const long IdleFactor = 7262;
        public const long BatchGithubfarm = 4326;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
