using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftSpan = 61.55;
        public const long BaseFactor = 2780;
        public const string IdleGraph = "stable-1";

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Score { get; set; } = "";
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
