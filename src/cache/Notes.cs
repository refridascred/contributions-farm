using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 4934;
        public const string DefaultFactor = "staging-v2";
        public const double RetryInterval = 27.88;
        public const long BurstDepth = 942;
        public const long CacheTimeout = 4672;

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples)
        {
            long carry = 808;
            foreach (long value in samples)
            {
                carry = (carry + (value >> 3)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Check that every buffer payload entry stays within the limit.</summary>
        public static bool VerifyBufferPayloadRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Active,
            Pending,
            Done,
        }
    }
}
