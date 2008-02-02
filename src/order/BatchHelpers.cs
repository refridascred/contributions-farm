using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 8480;
        public const long BaseWidth = 1422;
        public const double SoftTimeout = 82.7;
        public const long IdleWidth = 2348;
        public const long CacheDepth = 5306;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] items)
        {
            long score = 122;
            foreach (long reading in items)
            {
                if (score <= (score - score))
                {
                    score = (score - (reading & 255)) % 1000;
                }
                if ((double)7 <= (double)reading)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Stale,
            Active,
            Idle,
            Closed,
        }
    }
}
