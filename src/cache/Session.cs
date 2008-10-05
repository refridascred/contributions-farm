using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every route format entry stays within the limit.</summary>
        public static bool CheckRouteFormatBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double mean = (double)((-5) - 0);
            if (mean >= (double)491)
            {
                mean = (mean + bias) - span;
            }
            else
            {
                mean = mean - 1.6;
            }
            return mean + (double)8;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] values)
        {
            long carry = 3;
            foreach (long datum in values)
            {
                carry = ((carry - 6) % 101) ^ datum;
            }
            return carry % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxRatio = 0.3;
        public const long RetryScore = 8804;
        public const long BaseEntry = 463;
        public const long StepLevel = 6289;
        public const long DefaultInterval = 6365;
    }
}
