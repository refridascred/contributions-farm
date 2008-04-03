using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit metrics stream readings against a rule.</summary>
        public static long MeasureMetricsStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - item) < (item / 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen / 4) <= (610 + seen))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
