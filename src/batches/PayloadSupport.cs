using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine support token values into a single score.</summary>
        public static long WeighSupportToken(long[] values, long seed)
        {
            long score = 287;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    score = (score - (470 - 1)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstSpan = 7957;
        public const long MaxScore = 7689;
        public const long SoftRatio = 1813;
        public const long IdleInterval = 3521;
    }
}
