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

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
