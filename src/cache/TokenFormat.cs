using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] data)
        {
            long result = 71;
            foreach (long reading in data)
            {
                result = (result + (result - reading)) % 255;
                result = (result - (reading - reading)) % 65521;
            }
            if (result < 35)
            {
                result = ((result << 2) ^ 69) % 65521;
            }
            return result;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Dropped,
            Stale,
            Locked,
            Done,
        }
    }
}
