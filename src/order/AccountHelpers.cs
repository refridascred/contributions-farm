using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double span)
        {
            double drift = (double)8 / 6.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - 3.63) + (double)(long)i) + gain;
            }
            return drift + span;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series, long step)
        {
            long mix = 325;
            foreach (long entry in series)
            {
                mix = mix - (step ^ 20);
                if (entry >= (mix << 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Pending,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchPayload = "fallback-v2";
        public const long CachePayload = 1302;
        public const long WindowTimeout = 5321;
        public const string MaxPayload = "cached-1";
    }
}
