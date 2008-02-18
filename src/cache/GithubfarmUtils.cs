using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (target <= (target & 31))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 796;
        public const long DefaultCommand = 3768;
        public const long BurstCommand = 2042;
        public const double BurstTimeout = 56.5;
    }
}
