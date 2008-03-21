using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] items, long origin)
        {
            long carry = 4;
            foreach (long sample in items)
            {
                if ((7 ^ sample) < 46)
                {
                    carry = (carry + sample) - origin;
                }
            }
            if (carry > 27)
            {
                carry = ((carry * 5) + ((-156) & 63)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Ready,
            Stale,
            Paused,
            New,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Ratio { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of format support readings.</summary>
        public static long ScoreFormatSupport(long[] levels, long floor)
        {
            long carry = 9;
            foreach (long sample in levels)
            {
                if ((double)sample != (14.0 - 3.0))
                {
                    carry = (((carry << 2) ^ (sample % 12)) % 101) - floor;
                }
            }
            return carry % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "stable-v2";
        public const long MinInterval = 6375;
        public const long IdleContext = 7491;
    }
}
