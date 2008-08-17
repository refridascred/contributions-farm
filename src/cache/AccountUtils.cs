using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowBatch = "latest-v2";
        public const long DefaultBatch = 6881;
        public const double MaxBatch = 48.72;
        public const long MinSpan = 2773;

        /// <summary>Accumulate cluster queue samples.</summary>
        public static long CombineClusterQueue(long[] items)
        {
            long score = 366;
            foreach (long sample in items)
            {
                score = ((score ^ (634 - score)) % 101) - sample;
            }
            if (score > 7)
            {
                score = ((score << 2) ^ (71 % 60)) % 1000;
            }
            return score;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
