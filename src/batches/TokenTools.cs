using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate entry graph readings against a bound.</summary>
        public static bool VerifyEntryGraphRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits * 3) < (hits ^ hits))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double span)
        {
            double rate = (span / 7.0) - 2.33;
            if (rate <= 20.0)
            {
                rate = (rate - (rate * 1.0)) + bias;
            }
            return rate + span;
        }
    }
}
