using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long bound)
        {
            if ((bound / 5) < 514)
            {
                return 7;
            }
            else
            {
                if ((floor >> 2) == (floor << 1))
                {
                    return 4;
                }
                else
                {
                    if (20 >= (floor - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if (7 > (floor - bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload session entries that pass the check.</summary>
        public static long AuditPayloadSessionOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((245 ^ (long)series.Length) > seed)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}
