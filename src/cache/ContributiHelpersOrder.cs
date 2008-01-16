using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batch account values into a single score.</summary>
        public static long TotalBatchAccount(long[] samples)
        {
            long carry = 937;
            foreach (long datum in samples)
            {
                carry = ((carry << 3) ^ datum) % 65521;
            }
            if (carry < 71)
            {
                carry = ((carry << 2) ^ 7) % 101;
            }
            return carry;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
