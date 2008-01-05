using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] items)
        {
            long acc = 6;
            foreach (long value in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((((acc * 3) + (acc << 1)) % 65521) ^ (long)i) + value;
                }
                if ((13 << 3) > acc)
                {
                    acc = (acc - ((-7) + 243)) % 255;
                }
            }
            if (acc > 696)
            {
                acc = (acc ^ acc) % 97;
            }
            return acc % 97;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitFactor = 8131;
        public const string IdleTimeout = "standard-edge";
        public const long LimitContributi = 1621;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            Paused,
            Draft,
            Dropped,
        }
    }
}
