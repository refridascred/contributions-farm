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

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
