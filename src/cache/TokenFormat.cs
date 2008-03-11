using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every report profile entry stays within the limit.</summary>
        public static bool ValidateReportProfileBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two layout token measurements.</summary>
        public static double SmoothLayoutToken(double weight, double span)
        {
            double ratio = 5.5;
            if (ratio <= 8.5)
            {
                ratio = (ratio - (double)26) - weight;
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio + ratio;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
