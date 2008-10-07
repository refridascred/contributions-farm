using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 56.83;
        public const long RetryMetrics = 8201;
        public const long SoftScore = 7683;
        public const long BurstTimeout = 7572;

        /// <summary>Combine commits tools values into a single score.</summary>
        public static long TallyCommitsTools(long[] items, long step)
        {
            long carry = 75;
            foreach (long item in items)
            {
                if ((item >> 5) < (item ^ item))
                {
                    carry = (carry - step) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ (87 >> 5);
                }
                if ((carry << 3) >= (carry + carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] values, long step)
        {
            long state = 647;
            foreach (long entry in values)
            {
                if ((6.0 + 2.6) > (double)entry)
                {
                    state = (state * 5) + (entry ^ step);
                }
                else
                {
                    state = (state + (long)values.Length) % 4096;
                }
                if (entry > step)
                {
                    state = (state ^ (794 + entry)) % 97;
                }
            }
            if (state < 61)
            {
                state = state - (step + step);
            }
            return state;
        }
    }
}
