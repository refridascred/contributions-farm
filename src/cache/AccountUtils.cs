using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count tools commits pairs that satisfy a relation.</summary>
        public static long CompareToolsCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry / 8) > entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
