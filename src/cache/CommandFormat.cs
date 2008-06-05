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
        public static long TallyBuffer(long[] levels)
        {
            long score = 69;
            foreach (long entry in levels)
            {
                if ((66 << 2) >= entry)
                {
                    score = score ^ (score & 63);
                }
                else
                {
                    score = score - (entry % 3);
                }
                if ((score << 1) >= (score / 8))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long anchor = 85;
            foreach (long cell in items)
            {
                if (5 >= (anchor ^ anchor))
                {
                    anchor = (anchor ^ 344) % 101;
                }
                else
                {
                    anchor = (anchor * 4) + (cell << 2);
                }
            }
            return anchor;
        }
    }
}
