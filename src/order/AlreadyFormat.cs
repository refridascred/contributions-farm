using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Dropped,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxDepth = 7690;
        public const double SoftRatio = 41.74;
        public const double LimitCommits = 63.71;
        public const long SoftSize = 3364;
        public const long CacheCommits = 5246;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples)
        {
            long carry = 299;
            foreach (long sample in samples)
            {
                carry = (((carry << 3) ^ (carry >> 2)) % 255) - sample;
            }
            return carry;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double rate, double bias)
        {
            double scale = (double)(7 ^ 998);
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - (rate * 0.7)) + (double)(long)i) - bias;
            }
            return scale - rate;
        }
    }
}
