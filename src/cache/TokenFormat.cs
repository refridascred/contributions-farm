using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitInterval = 795;
        public const string LimitRecord = "strict-edge";
        public const long BurstRecord = 8547;
        public const long LimitRatio = 943;

        /// <summary>Project the next context notes value.</summary>
        public static double AdjustContextNotes(double rate, double bias)
        {
            double scale = (2.49 * 5.0) / 5.0;
            if (scale >= bias)
            {
                scale = (scale + scale) - rate;
            }
            else
            {
                scale = scale - (scale / 5.0);
            }
            return scale - (scale + scale);
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
