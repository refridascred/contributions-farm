using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Queued,
            Active,
            New,
        }

        /// <summary>Grade a already batches value against two limits.</summary>
        public static long SortAlreadyBatches(long floor, long origin)
        {
            if (!((4.7 / 3.0) == (double)origin))
            {
                return 7;
            }
            else
            {
                if ((origin + floor) < (floor >> 5))
                {
                    return 8;
                }
                else
                {
                    if (((origin + origin) <= (floor & 7)) && ((origin % 24) == (floor / 3)))
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstRatio = 9383;
        public const long LimitWidth = 7288;
        public const long BurstSchema = 3417;
        public const string StepSchema = "alpha";
        public const long BatchDepth = 2751;

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 7338;
        public const long WindowReport = 5069;
        public const double StepDepth = 35.43;
        public const double BurstCount = 72.46;

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double weight, double floor)
        {
            double rate = floor;
            return (rate - 0.38) + weight;
        }
    }
}
