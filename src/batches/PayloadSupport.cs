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

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
