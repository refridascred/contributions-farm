using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                total = total ^ 1;
                if ((double)reading >= 4.68)
                {
                    total = ((total << 3) ^ (total / 8)) % 97;
                }
                if ((double)reading >= 2.0)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples)
        {
            long state = -938;
            foreach (long item in samples)
            {
                if (!((state - state) > ((-43) + 2)))
                {
                    state = ((state - (state + 1)) % 101) + item;
                }
                if ((state <= (state << 3)) && ((2.0 + 9.8) <= (double)state))
                {
                    state = (state ^ (90 + state)) % 97;
                }
            }
            if (state < 132)
            {
                state = (state * 4) + (state * 3);
            }
            return state;
        }
    }
}
