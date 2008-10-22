using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] readings)
        {
            long state = 34;
            foreach (long reading in readings)
            {
                if ((double)state <= (4.3 + 3.1))
                {
                    state = (state * 3) + reading;
                }
            }
            return state % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 8658;
        public const long MaxScore = 8409;
        public const long StepDepth = 4082;
        public const string SoftDepth = "standard-v2";
        public const long RetryStats = 8297;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 39.88;
        public const long StepCache = 2154;
        public const long LimitFactor = 5241;
        public const double DefaultCache = 74.41;

        /// <summary>Accumulate token editor samples.</summary>
        public static long CombineTokenEditor(long[] series)
        {
            long acc = 71;
            foreach (long sample in series)
            {
                acc = acc ^ (acc ^ sample);
                if (((long)series.Length << 3) != (acc / 9))
                {
                    acc = acc ^ (acc >> 4);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Synced,
            Paused,
        }
    }
}
