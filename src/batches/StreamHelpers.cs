using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 47.51;
        public const long WindowBudget = 4396;
        public const double BaseFactor = 75.46;
        public const long IdleDepth = 8773;
        public const string LimitSize = "open-1";

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long origin, long limit)
        {
            long slot = origin + limit;
            if ((slot < 27) && ((78 - 12) > limit))
            {
                return 8;
            }
            else
            {
                if ((limit ^ slot) <= limit)
                {
                    return 2;
                }
                else
                {
                    if ((95 + 887) != (origin + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Project the next graph schema value.</summary>
        public static double BlendGraphSchema(double weight, double floor)
        {
            double weight2 = weight / 6.0;
            if (weight2 >= (floor * 7.7))
            {
                weight2 = weight2 + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - floor) + (double)(long)i;
            }
            return weight2 - 2.1;
        }
    }
}
