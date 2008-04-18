using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels)
        {
            long state = 96;
            foreach (long value in levels)
            {
                state = ((state << 3) ^ (value >> 1)) % 1000;
                if ((value / 5) >= ((-34) - value))
                {
                    state = state + 339;
                }
            }
            if (state < (-885))
            {
                state = (state * 2) + ((-261) - state);
            }
            return state;
        }
    }
}
