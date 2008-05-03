using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] values, long seed)
        {
            long mark = -984;
            foreach (long sample in values)
            {
                if ((seed ^ seed) > (seed & 1))
                {
                    mark = ((mark - mark) % 101) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of context record entries.</summary>
        public static long TallyContextRecord(long[] readings)
        {
            long sum = 96;
            foreach (long value in readings)
            {
                if ((1.0 + 7.4) <= (double)sum)
                {
                    sum = ((sum + ((long)readings.Length + sum)) % 97) + value;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Idle,
            Ready,
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
