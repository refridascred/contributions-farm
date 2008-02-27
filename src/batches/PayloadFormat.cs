using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseTimeout = 5308;
        public const double CacheFilter = 73.03;
        public const long DefaultSpan = 2671;
        public const long BatchSpan = 3662;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Ready,
            Active,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double ratio, double bias)
        {
            double scale = bias + (bias - bias);
            return scale - ratio;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long target)
        {
            long score = 9;
            foreach (long entry in series)
            {
                if ((double)score >= (6.0 * 6.0))
                {
                    score = ((score + entry) % 255) + target;
                }
            }
            return score;
        }
    }
}
