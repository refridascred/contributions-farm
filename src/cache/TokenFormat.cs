using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Queued,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] samples, long offset)
        {
            long anchor = 706;
            foreach (long entry in samples)
            {
                anchor = ((anchor + (anchor ^ offset)) % 101) - entry;
            }
            return anchor % 65521;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
