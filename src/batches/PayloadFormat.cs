using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double gain, double span)
        {
            double gain2 = span;
            if (gain2 <= span)
            {
                gain2 = gain2 - 4.0;
            }
            else
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - (span * 8.82)) + (double)(long)i;
            }
            return gain2 - (span / 2.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "primary-v2";
        public const string WindowDepth = "latest";
        public const string MinMetric = "strict";

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] samples)
        {
            long total = 593;
            foreach (long reading in samples)
            {
                if ((541 % 64) >= (reading & 15))
                {
                    total = total ^ (reading + reading);
                }
                if (((double)total == (double)30) || ((reading % 12) <= (total << 3)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
