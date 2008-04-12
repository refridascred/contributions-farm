using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((-399) & 63) >= seen)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile queue readings.</summary>
        public static long DigestProfileQueue(long[] values)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = (total - datum) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] samples, long floor)
        {
            long state = 14;
            foreach (long sample in samples)
            {
                if ((floor * 3) == (floor + state))
                {
                    state = ((state - (state / 7)) % 255) + sample;
                }
            }
            return state % 65521;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
