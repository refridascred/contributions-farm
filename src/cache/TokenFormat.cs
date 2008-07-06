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

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long limit, long offset)
        {
            if ((13.0 / 4.0) < (double)offset)
            {
                return 3;
            }
            else
            {
                if ((limit << 1) >= (limit / 2))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
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
