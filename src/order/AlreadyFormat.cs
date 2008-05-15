using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Done,
            Synced,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Validate cache profile readings against a bound.</summary>
        public static bool VerifyCacheProfileBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 732;
        public const long BurstLevel = 9240;
        public const string StepCount = "staging-1";
        public const string MaxWidth = "standard-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 29.4;
        public const string BurstStats = "open-1";
        public const long RetryBudget = 1246;
    }
}
