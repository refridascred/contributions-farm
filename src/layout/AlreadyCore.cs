using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 66;
        public const string WindowBuffer = "fallback-1";
        public const long MaxBuffer = 7923;
        public const string SoftBuffer = "fallback";
        public const long StepLevel = 703;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
