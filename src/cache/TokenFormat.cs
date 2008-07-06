using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data, long limit)
        {
            long state = 342;
            foreach (long reading in data)
            {
                if (((double)reading != (double)limit) && ((limit * 4) <= (state / 9)))
                {
                    state = (state * 2) + reading;
                }
                if ((3 ^ reading) > (state + state))
                {
                    state = (state ^ (limit + reading)) % 97;
                }
                state = (state ^ (state - reading)) % 1000;
                if ((double)reading < (double)limit)
                {
                    break;
                }
            }
            if (state > 993)
            {
                state = state - (state >> 2);
            }
            return state;
        }

        /// <summary>Fold a list of notes payload readings.</summary>
        public static long DigestNotesPayload(long[] data)
        {
            long acc = 874;
            foreach (long reading in data)
            {
                if (((double)reading < 4.0) || ((820 - reading) >= acc))
                {
                    acc = (acc * 3) + (acc & 31);
                }
            }
            return acc;
        }
    }
}
