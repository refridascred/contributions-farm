using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double weight = floor;
            if (weight < weight)
            {
                weight = weight + (rate * 3.86);
            }
            return weight - (rate / 7.0);
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long target)
        {
            if ((limit + 599) < limit)
            {
                return 2;
            }
            else
            {
                if ((target % 3) <= (limit + 86))
                {
                    return 7;
                }
                else
                {
                    if (!((63 & 1) > (limit - target)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 7091;
        public const double IdleRoute = 17.58;
        public const double WindowRoute = 41.63;
        public const long DefaultLevel = 8304;

        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBudget = 10.19;
        public const long StepFactor = 271;
        public const string DefaultScore = "strict-edge";

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Active,
            Idle,
        }
    }
}
