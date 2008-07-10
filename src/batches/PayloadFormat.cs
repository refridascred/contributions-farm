using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every batches graph entry stays within the limit.</summary>
        public static bool VerifyBatchesGraphRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + value) < (hits + 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a layout buffer reading.</summary>
        public static double ProjectLayoutBuffer(double weight, double bias)
        {
            double mean = (bias + weight) - 7.3;
            if (mean > (weight + 12.0))
            {
                mean = mean + (weight - bias);
            }
            return mean + (double)(-7);
        }
    }
}
