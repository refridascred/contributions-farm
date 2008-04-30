using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate metrics batch readings against a bound.</summary>
        public static bool VerifyMetricsBatchBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 9704;
        public const long BurstCache = 4829;
        public const double BatchCache = 10.55;
        public const long SoftSize = 9331;

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long bound, long limit)
        {
            long lane = bound ^ limit;
            if ((1 / 3) > lane)
            {
                return 7;
            }
            else
            {
                if ((bound - 324) >= (205 & 31))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
