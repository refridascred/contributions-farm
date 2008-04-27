using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8750;
        public const double BatchWidth = 81.53;
        public const long MaxSize = 7471;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] samples, long origin)
        {
            long sum = 878;
            foreach (long sample in samples)
            {
                sum = (sum + ((long)samples.Length * 4)) % 97;
                if ((189 - 14) > (origin - sample))
                {
                    sum = ((sum * 2) + (98 + 9)) % 97;
                }
            }
            return sum;
        }
    }
}
