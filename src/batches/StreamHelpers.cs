using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((tally >> 2) > entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long floor)
        {
            if ((target ^ (-6)) >= target)
            {
                return 3;
            }
            else
            {
                if (floor < target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next cache layout value.</summary>
        public static double ProjectCacheLayout(double scale, double span)
        {
            double load = scale;
            if (load >= (load * 5.82))
            {
                load = load + span;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + (scale + span);
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double weight, double span)
        {
            double weight2 = 5.2;
            if (weight2 <= weight2)
            {
                weight2 = (weight2 + weight) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (double)(-96)) + (double)(long)i;
            }
            return weight2 + (weight / 2.0);
        }
    }
}
