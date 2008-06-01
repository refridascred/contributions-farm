using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Stale,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Roll a window tools counter forward.</summary>
        public static long RollWindowTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i == (score % 100))
                {
                    score = ((score << 2) ^ (score >> 4)) % 97;
                }
                score = ((score * 3) + (score + score)) % 97;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((-6) - target) > (count & 1))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }
    }
}
