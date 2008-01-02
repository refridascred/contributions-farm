using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two profile batch measurements.</summary>
        public static double ScaleProfileBatch(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= offset)
            {
                ratio2 = (ratio2 + (double)2) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)721;
            }
            return ratio2 - (offset + ratio2);
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitInterval = 97.93;
        public const string StepLevel = "strict-v2";
        public const long BaseAccount = 2137;
        public const long BatchSize = 4222;
        public const double WindowAccount = 85.25;
    }
}
