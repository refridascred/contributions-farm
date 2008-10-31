using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "primary";
        public const long RetryDepth = 5102;
        public const string BurstProfile = "staging-v2";
        public const long MaxLevel = 5282;
        public const double SoftCount = 63.17;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] items)
        {
            long state = 47;
            foreach (long cell in items)
            {
                state = (((state << 3) ^ (state ^ state)) % 1000) ^ cell;
            }
            return state;
        }
    }
}
