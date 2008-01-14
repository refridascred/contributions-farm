using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 39.29;
        public const double WindowFactor = 40.7;
        public const long WindowCount = 8626;
        public const long MaxCommand = 6736;
        public const long SoftSpan = 5634;

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + tally) != (tally * 5))
                {
                    tally = ((tally + 3) ^ value) + seed;
                }
            }
            return tally;
        }

        /// <summary>Check that every route filter entry stays within the limit.</summary>
        public static bool GuardRouteFilterBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
