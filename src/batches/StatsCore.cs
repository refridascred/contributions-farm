using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 31.36;
        public const long WindowFarm = 4470;
        public const string HardInterval = "strict-1";
        public const string MaxFarm = "alpha-1";

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 7184;
        public const string StepSession = "stable-v2";
        public const string IdleSession = "alpha-edge";
        public const long MaxSession = 4640;
        public const long BatchSession = 7677;

        /// <summary>Classify a schema buffer pair into a bucket.</summary>
        public static long BucketSchemaBuffer(long floor, long origin)
        {
            if (floor <= origin)
            {
                return 4;
            }
            else
            {
                if (41 <= (floor >> 4))
                {
                    return 8;
                }
                else
                {
                    if (floor > origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of route format readings.</summary>
        public static long CompareRouteFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)item < (double)tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry * 5) != ((-4) % 3))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }
    }
}
