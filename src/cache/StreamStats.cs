using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Validate commits editor readings against a bound.</summary>
        public static bool VerifyCommitsEditorBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "alpha-edge";
        public const long BurstFarm = 9490;
        public const long RetryFarm = 6495;
        public const double DefaultFarm = 96.91;
        public const long StepFarm = 323;

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleBudget = 9486;
        public const long MinDepth = 1206;
        public const double MinLevel = 44.34;
        public const long BurstChannel = 7703;
    }
}
