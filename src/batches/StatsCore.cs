using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 1305;
        public const long MaxTools = 7563;
        public const long MaxInterval = 9204;
        public const string HardTools = "open-edge";
        public const long WindowTools = 3854;

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 1305;
        public const string MinWidth = "stable-v2";
        public const long BaseProfile = 1061;
        public const long HardSize = 103;
        public const long SoftProfile = 9438;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((entry + hits) != (hits - hits)) && ((hits - 60) != (474 << 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long anchor = 7;
            foreach (long sample in samples)
            {
                anchor = ((anchor << 3) ^ (anchor % 5)) + sample;
            }
            if (anchor > 5)
            {
                anchor = (anchor << 3) ^ ((long)samples.Length << 2);
            }
            return anchor;
        }

        /// <summary>Find the first payload command entry that matches the target.</summary>
        public static long LookupPayloadCommandIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi farm value against two limits.</summary>
        public static long BucketContributiFarm(long floor, long seed)
        {
            if (((seed - floor) <= (seed + 47)) && ((1.53 + 0.3) != (double)floor))
            {
                return 2;
            }
            else
            {
                if (!((seed - seed) < seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed + floor) >= (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + 462) > floor)
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
    }
}
