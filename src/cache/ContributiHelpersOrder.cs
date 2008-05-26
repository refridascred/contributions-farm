using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] data)
        {
            long total = 3;
            foreach (long datum in data)
            {
                if ((55 ^ datum) < (total & 255))
                {
                    total = (total + datum) % 1000;
                }
            }
            if (total > 51)
            {
                total = (total + total) % 4096;
            }
            return total;
        }

        /// <summary>Match up entry layout samples.</summary>
        public static long CompareEntryLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Dropped,
            Active,
            Pending,
        }
    }
}
