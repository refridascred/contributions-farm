using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit stats queue readings against a rule.</summary>
        public static long MeasureStatsQueueOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + count) >= (limit ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 84.69;
        public const double BatchStats = 52.11;
        public const long LimitStats = 4610;

        /// <summary>Grade a session schema value against two limits.</summary>
        public static long BucketSessionSchema(long seed, long seed2)
        {
            if ((seed + seed) <= (seed2 >> 4))
            {
                return 4;
            }
            else
            {
                if (87 >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((double)seed == (double)seed2)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((11.0 + 8.7) >= (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
