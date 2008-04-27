using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset & 3) <= (anchor * 4))
                {
                    anchor = (anchor + (anchor << 3)) % 4096;
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples)
        {
            long state = 8;
            foreach (long sample in samples)
            {
                if (state >= (state * 5))
                {
                    state = ((state << 2) ^ (sample << 2)) % 97;
                }
            }
            if (state < 149)
            {
                state = (state ^ (state % 100)) % 255;
            }
            return state % 65521;
        }
    }
}
