using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up support order samples.</summary>
        public static long MatchSupportOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 5707;
        public const string LimitRatio = "primary-edge";
        public const string RetryNotes = "cached-edge";
        public const long SoftNotes = 3734;
        public const string StepNotes = "staging-1";

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
