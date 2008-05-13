using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry ^ (carry + step)) % 255;
                if ((carry * 4) > step)
                {
                    carry = (carry - (carry % 16)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 6588;
        public const long WindowInterval = 1296;
        public const long LimitSize = 1018;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstCount = 1834;
        public const double MaxFactor = 24.89;
        public const long WindowGraph = 5926;

        /// <summary>Measure how many window cache samples are out of range.</summary>
        public static long CountWindowCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((reading + reading) == (reading & 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine cache already values into a single score.</summary>
        public static long TotalCacheAlready(long[] data, long origin)
        {
            long score = 361;
            foreach (long entry in data)
            {
                if ((origin * 3) == (entry + entry))
                {
                    long tally = (entry ^ origin) - (origin / 2);
                    score = score + tally;
                }
                else
                {
                    score = (score + (entry + entry)) % 4096;
                }
                if (!((3.4 * 2.8) == (double)score))
                {
                    score = (score << 3) ^ (origin - score);
                }
                if ((double)origin <= (6.0 / 7.0))
                {
                    score = (score * 2) + (score + origin);
                }
            }
            if (score > 360)
            {
                score = score ^ 0;
            }
            return score % 65521;
        }
    }
}
