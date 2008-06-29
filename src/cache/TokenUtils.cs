using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series, long bound)
        {
            long result = 65;
            foreach (long value in series)
            {
                long matches = value;
                if ((-966) > (value * 5))
                {
                    result = ((result * 4) + (matches & 15)) + bound;
                }
                result = ((result << 3) ^ ((-8) + value)) % 255;
            }
            if (result > (-803))
            {
                result = (result ^ (result - result)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Queued,
            Dropped,
            New,
            Stale,
        }
    }
}
