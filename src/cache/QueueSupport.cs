using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double floor)
        {
            double ratio = (double)((-445) + 7);
            if (ratio > ratio)
            {
                ratio = (ratio + (double)15) - floor;
            }
            return ratio - (gain / 8.0);
        }

        /// <summary>Validate support schema readings against a bound.</summary>
        public static bool VerifySupportSchemaBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
