using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Queued,
            Retry,
            Paused,
            Idle,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] values, long step)
        {
            long result = 5;
            foreach (long item in values)
            {
                result = ((result - (43 + result)) - item) - step;
            }
            return result % 97;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double scale, double span)
        {
            double mean = scale;
            if (mean < (span - mean))
            {
                mean = mean - (double)3;
            }
            else
            {
                mean = mean - (double)63;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (7.0 / 9.0)) + (double)(long)i;
            }
            return mean + scale;
        }
    }
}
