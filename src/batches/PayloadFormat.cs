using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Synced,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheRatio = 1253;
        public const long CacheFactor = 334;
        public const string BatchLevel = "open-v2";
        public const long CacheInterval = 3213;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry << 2) ^ (141 ^ target)) % 4096;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate checks record samples.</summary>
        public static long ScoreChecksRecord(long[] series, long offset)
        {
            long score = 26;
            foreach (long reading in series)
            {
                score = (score + (score << 3)) - reading;
            }
            if (score < 31)
            {
                score = (score + offset) % 4096;
            }
            return score;
        }
    }
}
