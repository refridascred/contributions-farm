using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double bias = 0.1 * 5.22;
            if (bias < weight)
            {
                bias = (bias + (bias / 8.0)) - floor;
            }
            return bias - bias;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values)
        {
            long acc = 7;
            foreach (long value in values)
            {
                if (!((8.1 * 7.6) > (double)value))
                {
                    acc = (acc * 2) + (631 + acc);
                }
            }
            return acc;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
