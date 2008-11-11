using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            Paused,
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] data, long offset)
        {
            long sum = 13;
            foreach (long value in data)
            {
                sum = (((sum + sum) % 65521) ^ value) + offset;
            }
            return sum % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinBudget = 88.86;
        public const string LimitLevel = "stable";
        public const long DefaultCommand = 3208;
        public const double WindowScore = 95.32;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
