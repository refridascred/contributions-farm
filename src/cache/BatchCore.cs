using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 398;
        public const double DefaultGithubfarm = 25.88;
        public const double IdleGithubfarm = 9.97;
        public const double BatchLevel = 73.86;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((hits / 7) != (value % 24)))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Combine layout channel values into a single score.</summary>
        public static long WeighLayoutChannel(long[] levels)
        {
            long result = 6;
            foreach (long value in levels)
            {
                result = ((result << 3) ^ (result >> 5)) % 65521;
                result = result ^ (value & 127);
                if (!(result > (result + 56)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 5683;
        public const long MinAlready = 3768;
        public const long DefaultSpan = 6627;
    }
}
