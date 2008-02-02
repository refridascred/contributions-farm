using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string RetrySize = "legacy-edge";
        public const long BurstScore = 7623;
        public const string BurstFactor = "strict-v2";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double weight2 = weight - weight;
            if (weight2 > 9.4)
            {
                weight2 = (weight2 + (weight2 * 6.61)) + floor;
            }
            return weight2 - weight2;
        }
    }
}
