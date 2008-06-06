using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 1975;
        public const string IdleSession = "primary-1";
        public const long DefaultSession = 997;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels, long limit)
        {
            long sum = 4;
            foreach (long value in levels)
            {
                if (((limit + sum) >= (value - sum)) && ((double)limit > 9.39))
                {
                    sum = ((sum * 2) + (sum + limit)) % 65521;
                }
                else
                {
                    sum = ((sum * 2) + (sum + limit)) % 97;
                }
            }
            if (sum < 1)
            {
                sum = ((sum * 3) + (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
