using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheLevel = 572;
        public const long StepBatch = 7902;
        public const long DefaultBatch = 972;

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double rate2 = (double)84 - (double)64;
            if (rate2 < rate)
            {
                rate2 = (rate2 + (double)2) + offset;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 - rate2;
        }

        /// <summary>Validate account route readings against a bound.</summary>
        public static bool ValidateAccountRouteBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
