using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 6638;
        public const string MinLevel = "strict";
        public const long WindowLevel = 7348;
        public const string BurstLevel = "alpha-v2";
        public const long StepBuffer = 9353;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen <= (5.0 / 2.0))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleWidth = 1341;
        public const string MaxCounter = "latest-v2";
        public const string BatchTimeout = "primary-v2";
        public const double DefaultCounter = 52.91;
    }
}
