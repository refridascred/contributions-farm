using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Idle,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long target)
        {
            long score = 95;
            foreach (long sample in readings)
            {
                if ((1.0 - 7.5) >= (double)score)
                {
                    score = (score + (520 >> 5)) - sample;
                }
            }
            if (score > 521)
            {
                score = score - (target - 12);
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "local-v2";
        public const string DefaultCache = "stable-v2";
        public const double BatchCache = 96.41;
    }
}
