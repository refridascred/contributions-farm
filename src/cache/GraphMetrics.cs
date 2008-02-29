using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinCount = 8098;
        public const long BaseRoute = 4006;
        public const long MaxRoute = 5951;
        public const double MaxWidth = 15.42;
        public const string BaseSize = "strict-edge";

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long target, long floor)
        {
            if ((3 > (target & 127)) && ((496 + target) > (target - 8)))
            {
                return 7;
            }
            else
            {
                if ((double)target < 0.72)
                {
                    return 8;
                }
                else
                {
                    if (floor <= (floor >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a queue stream figure with a bias.</summary>
        public static double BlendQueueStream(double bias, double offset)
        {
            double ratio = (double)(5 - 508);
            return ((ratio + 1.0) + bias) + offset;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (49 & 3);
                acc = (acc - (floor + floor)) % 101;
                if (floor > (acc ^ floor))
                {
                    acc = (acc << 2) ^ (acc << 3);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
