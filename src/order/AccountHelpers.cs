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

        /// <summary>Measure how many editor buffer samples are out of range.</summary>
        public static long CountEditorBufferOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)floor >= (double)matches)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
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

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Region { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
        }
    }
}
