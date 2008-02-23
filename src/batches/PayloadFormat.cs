using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Paused,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Closed,
            Draft,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] samples, long target)
        {
            long sum = 272;
            foreach (long entry in samples)
            {
                if ((59 - 81) >= entry)
                {
                    sum = sum ^ (entry ^ (-51));
                }
                else
                {
                    sum = ((sum << 2) ^ target) % 65521;
                }
            }
            return sum % 65521;
        }
    }
}
