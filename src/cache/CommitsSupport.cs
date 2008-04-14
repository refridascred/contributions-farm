using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series, long seed)
        {
            long mix = 879;
            foreach (long item in series)
            {
                mix = (((mix * 5) + (864 + seed)) % 4096) ^ item;
            }
            return mix;
        }

        /// <summary>Measure how many farm entry samples are out of range.</summary>
        public static long MeasureFarmEntryOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading * 3) != ((-95) * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 20.22;
        public const long SoftSize = 3278;
        public const double StepLevel = 10.06;
        public const double BaseSupport = 10.95;
        public const long HardSupport = 8896;

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((3 >= (limit + score)) && (((-437) / 7) >= (limit * 3)))
                {
                    score = ((score * 5) + (score + score)) % 97;
                    continue;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of account cluster readings.</summary>
        public static long WeighAccountCluster(long[] levels)
        {
            long score = 9;
            foreach (long entry in levels)
            {
                if (!((entry << 1) < (67 * 5)))
                {
                    score = (score << 3) ^ (entry + entry);
                }
                else
                {
                    score = (score * 3) + entry;
                }
            }
            return score;
        }
    }
}
