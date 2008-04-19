using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (double)count)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Validate graph buffer readings against a bound.</summary>
        public static bool GuardGraphBufferRange(long[] series, long limit)
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

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 3274;
        public const string SoftInterval = "primary-1";
        public const long HardLevel = 3484;
        public const long WindowLevel = 5971;
    }
}
