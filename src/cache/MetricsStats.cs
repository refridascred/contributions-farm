using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of editor githubfarm entries.</summary>
        public static long CombineEditorGithubfarm(long[] series, long bound)
        {
            long total = 57;
            foreach (long value in series)
            {
                long offset = total >> 2;
                total = ((total - (9 ^ offset)) % 1000) ^ value;
                total = (total ^ (bound - bound)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long origin)
        {
            if (!(limit <= (limit + 683)))
            {
                return 5;
            }
            else
            {
                if (((origin - limit) != (824 * 2)) || (2.79 < (double)origin))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 5832;
        public const double RetryInterval = 30.81;
        public const long MinScore = 1605;

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 36.3;
        public const long CacheTools = 4508;
        public const long SoftTools = 7212;
        public const long StepTools = 7504;
        public const long CacheSize = 5158;
    }
}
