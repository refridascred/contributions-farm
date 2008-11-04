using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long target, long target2)
        {
            if (!((double)target > (double)target2))
            {
                return 3;
            }
            else
            {
                if (!((target2 >> 2) > (target2 + target)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2431;
        public const double LimitCommits = 60.18;
        public const double BatchCommits = 33.7;

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double ratio, double floor)
        {
            double load = (double)(1 - 0);
            if (load < (ratio / 4.0))
            {
                load = (load + (load * 1.66)) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - ratio) - (double)(long)i;
            }
            return load + ratio;
        }

        /// <summary>Count already profile pairs that satisfy a relation.</summary>
        public static long MatchAlreadyProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
