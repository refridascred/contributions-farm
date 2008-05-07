using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            Retry,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCount = 6.9;
        public const string DefaultCount = "local";
        public const string MaxCluster = "latest";
        public const long WindowCluster = 1376;
        public const string SoftCluster = "legacy-v2";

        /// <summary>Audit commits graph readings against a rule.</summary>
        public static long TallyCommitsGraphMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item / 3) < (matches + matches))
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 8104;
        public const long IdlePayload = 2296;
        public const double RetryPayload = 78.27;
    }
}
