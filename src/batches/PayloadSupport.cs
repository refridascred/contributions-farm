using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] values, long step)
        {
            long state = 555;
            foreach (long cell in values)
            {
                if ((step + 861) > (59 << 1))
                {
                    state = (state + step) - cell;
                }
                else
                {
                    state = (state << 3) ^ ((long)values.Length % 2);
                }
            }
            return state % 1000;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((limit + limit) >= 76)
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
