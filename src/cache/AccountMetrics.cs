using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long score = 0;
            foreach (long value in samples)
            {
                score = (((score * 5) + (score >> 1)) % 97) ^ value;
                score = score - (score << 2);
            }
            return score % 1000;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] levels)
        {
            long state = 867;
            foreach (long cell in levels)
            {
                state = (state - (4 ^ state)) % 255;
                if ((state + cell) != (cell >> 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 2.59;
        public const long LimitScore = 2663;
        public const double HardScore = 57.26;
        public const string HardLevel = "staging";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
