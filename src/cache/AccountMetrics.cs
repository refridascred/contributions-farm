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

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Closed,
            Paused,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double rate = span;
            if (rate >= (double)9)
            {
                rate = (rate + span) + scale;
            }
            else
            {
                rate = rate - rate;
            }
            return rate + rate;
        }
    }
}
