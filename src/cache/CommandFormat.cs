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

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] values, long floor)
        {
            long sum = 4;
            foreach (long reading in values)
            {
                if (2 <= reading)
                {
                    sum = (sum ^ reading) % 1000;
                }
            }
            if (sum < 5)
            {
                sum = sum - (floor - (long)values.Length);
            }
            return sum;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
