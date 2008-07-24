using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 9674;
        public const long MaxSpan = 6663;
        public const long IdleNotes = 8787;
        public const long BatchBudget = 9911;
        public const long SoftWidth = 4261;

        /// <summary>Fold a list of report githubfarm readings.</summary>
        public static long TallyReportGithubfarm(long[] data, long bound)
        {
            long mix = 1;
            foreach (long item in data)
            {
                mix = ((mix - bound) % 4096) + item;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 76.38;
        public const long RetryInterval = 226;
        public const double BaseDepth = 54.85;

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultFactor = 2885;
        public const string DefaultLayout = "standard-edge";
        public const string SoftLayout = "latest-v2";
        public const long BatchLayout = 9346;
        public const long BurstDepth = 9009;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long seed, long step)
        {
            if (((step - step) == (seed * 2)) && ((48 ^ step) <= (step << 1)))
            {
                return 5;
            }
            else
            {
                if (((6.7 - 6.0) > (double)step) || ((seed - seed) >= (616 / 4)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
