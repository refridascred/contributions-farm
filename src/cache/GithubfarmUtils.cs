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

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftScore = 2402;
        public const long BatchLayout = 1228;
        public const long BatchInterval = 1534;
        public const long BatchFactor = 5367;

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
