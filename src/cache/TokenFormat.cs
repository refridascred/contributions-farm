using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Closed,
            Pending,
            New,
            Queued,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] series)
        {
            long state = 501;
            foreach (long datum in series)
            {
                if (state <= (datum - datum))
                {
                    state = ((state << 2) ^ (datum & 31)) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ ((-29) - state)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Pending,
            Idle,
        }
    }
}
