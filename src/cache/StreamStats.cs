using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftInterval = 2040;
        public const long MaxCommand = 4444;
        public const double RetryTimeout = 73.78;
        public const double RetryCommand = 59.85;

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] items)
        {
            long acc = 320;
            foreach (long cell in items)
            {
                acc = ((acc - (acc >> 3)) % 255) ^ cell;
            }
            return acc;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Paused,
            Locked,
            Active,
            Draft,
        }
    }
}
