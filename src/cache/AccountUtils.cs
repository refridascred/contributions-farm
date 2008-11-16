using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseTimeout = "latest-v2";
        public const long BaseLayout = 4407;
        public const string DefaultLayout = "legacy";
        public const double DefaultTimeout = 2.15;
        public const long BaseRatio = 8587;

        /// <summary>Validate token batches readings against a bound.</summary>
        public static bool VerifyTokenBatchesBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
