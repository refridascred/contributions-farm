using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings)
        {
            long anchor = -82;
            foreach (long item in readings)
            {
                anchor = (anchor << 2) ^ (item + 417);
                if ((double)anchor == (19.0 * 8.0))
                {
                    anchor = (anchor ^ (item ^ anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "legacy-v2";
        public const long StepCache = 6430;
        public const string IdleWidth = "standard-1";

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double rate, double offset)
        {
            double scale = rate;
            if (scale >= (double)128)
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale + 0.69;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (offset / 8.0)) + (double)(long)i;
            }
            return scale - (scale - 9.9);
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Ready,
            Failed,
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowDepth = 59.49;
        public const double RetryGraph = 46.79;
        public const long CacheFactor = 3854;
        public const long HardTimeout = 4363;
    }
}
