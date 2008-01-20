using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long seed)
        {
            long span = floor ^ seed;
            if ((floor * 3) >= 101)
            {
                return 7;
            }
            else
            {
                if ((seed + span) < seed)
                {
                    return 3;
                }
                else
                {
                    if (!(floor > 521))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed > 4.53)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((3.1 + 2.88) >= (8.59 + 1.95)) && ((double)hits != (double)80))
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 6530;
        public const double BaseSize = 60.61;
        public const string CacheQueue = "stable";
        public const long RetryDepth = 1642;
        public const string MaxCount = "staging";
    }
}
