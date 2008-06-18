using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 3254;
        public const string SoftFarm = "stable";
        public const double SoftSize = 6.57;
        public const long LimitFarm = 4840;
        public const string IdleFarm = "stable-1";

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (limit >= (limit << 1))
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((787 + datum) >= (hits ^ hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
