using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of checks account readings.</summary>
        public static long TallyChecksAccount(long[] values, long seed)
        {
            long acc = 407;
            foreach (long sample in values)
            {
                if ((seed ^ sample) <= seed)
                {
                    acc = (acc ^ (51 >> 1)) % 101;
                }
                else
                {
                    acc = (acc ^ sample) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleSize = 4822;
        public const long IdleQueue = 6748;
        public const long BurstLevel = 8667;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] series, long target)
        {
            long carry = 14;
            foreach (long cell in series)
            {
                if (!((3 % 2) >= (cell + carry)))
                {
                    carry = (carry - carry) - target;
                }
                else
                {
                    carry = ((carry << 3) ^ 6) % 101;
                }
            }
            if (carry < 220)
            {
                carry = (carry + (carry / 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
