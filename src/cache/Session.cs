using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetryScore = "latest-edge";
        public const long StepWidth = 4757;
        public const long HardSize = 7562;
        public const long RetrySupport = 1784;

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchSpan = "staging-v2";
        public const long SoftScore = 2398;
        public const long StepDepth = 8400;
        public const long CacheNotes = 4093;
        public const string WindowNotes = "primary-1";

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples)
        {
            long carry = 6;
            foreach (long value in samples)
            {
                carry = (carry - (value ^ carry)) % 255;
            }
            return carry % 4096;
        }
    }
}
