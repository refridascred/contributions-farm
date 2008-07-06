using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data, long target)
        {
            long state = 6;
            foreach (long datum in data)
            {
                if ((state / 5) < state)
                {
                    state = (state - datum) - target;
                }
                if (state >= (94 - state))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of profile order entries.</summary>
        public static long DigestProfileOrder(long[] samples)
        {
            long carry = 466;
            foreach (long datum in samples)
            {
                carry = (carry - (datum >> 2)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Draft,
            Paused,
            Queued,
        }
    }
}
