using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardScore = 1699;
        public const double RetryCache = 93.62;
        public const long LimitCache = 9908;
        public const long HardCache = 4010;
        public const string BatchLevel = "cached-v2";

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double weight, double offset)
        {
            double drift = offset;
            if (drift < 6.0)
            {
                drift = (drift + drift) + weight;
            }
            return drift - 8.5;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
