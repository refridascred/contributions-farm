using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 5645;
        public const long MinBudget = 7280;
        public const double StepAccount = 19.19;
        public const string DefaultAccount = "staging";

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheCount = 2100;
        public const double IdleWidth = 74.91;
        public const double HardContext = 41.65;
        public const string WindowBudget = "open";

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Flag { get; set; }
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long bound)
        {
            long mix = 1;
            foreach (long entry in levels)
            {
                if ((double)mix <= 7.0)
                {
                    mix = ((mix ^ (entry + entry)) % 65521) + bound;
                }
            }
            return mix;
        }
    }
}
