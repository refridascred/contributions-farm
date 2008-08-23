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

        /// <summary>Grade a already record value against two limits.</summary>
        public static long BucketAlreadyRecord(long offset, long bound)
        {
            if (bound > (bound + 6))
            {
                return 4;
            }
            else
            {
                if (((double)bound <= (7.2 / 5.0)) && ((bound / 4) >= (bound + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset != (4.1 / 3.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
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
