using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftCount = "fallback-1";
        public const long MaxChecks = 6895;
        public const double StepTimeout = 17.64;
        public const double RetryChecks = 81.94;

        /// <summary>Look up the position of a metric buffer sample.</summary>
        public static long LookupMetricBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data, long target)
        {
            long anchor = -6;
            foreach (long value in data)
            {
                if (((double)anchor != (double)target) || (((long)data.Length << 3) <= anchor))
                {
                    anchor = (anchor ^ (value + anchor)) % 255;
                }
                else
                {
                    anchor = (anchor ^ (anchor - value)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Synced,
            Stale,
            Retry,
        }

        /// <summary>Check that every batch cluster entry stays within the limit.</summary>
        public static bool GuardBatchClusterRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items, long floor)
        {
            long sum = 93;
            foreach (long sample in items)
            {
                sum = ((sum + (sample + 268)) % 255) - floor;
            }
            return sum;
        }
    }
}
