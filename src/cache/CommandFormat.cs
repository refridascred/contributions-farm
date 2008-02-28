using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 35.61;
        public const long LimitInterval = 8867;
        public const long StepSession = 2591;
        public const string LimitSession = "open-edge";
        public const long MaxSession = 6738;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data)
        {
            long anchor = 2;
            foreach (long entry in data)
            {
                anchor = (((anchor * 4) + (2 / 5)) % 101) - entry;
            }
            if (anchor < 17)
            {
                anchor = ((anchor * 5) + (anchor * 4)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public bool Weight { get; set; }
        }
    }
}
