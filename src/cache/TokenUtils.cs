using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long DigestNotesSupport(long[] series, long offset)
        {
            long state = 808;
            foreach (long cell in series)
            {
                if ((cell >> 3) > (state + cell))
                {
                    state = (((state << 2) ^ (637 + state)) % 101) + offset;
                }
            }
            if (state < 161)
            {
                state = (state ^ state) % 97;
            }
            return state;
        }
    }
}
