using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long offset)
        {
            if (((offset + floor) != (floor + offset)) && ((floor ^ offset) == (offset * 4)))
            {
                return 2;
            }
            else
            {
                if ((offset / 3) > offset)
                {
                    return 1;
                }
                else
                {
                    if ((700 >> 2) == (floor - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a format batch figure with a bias.</summary>
        public static double ScaleFormatBatch(double weight, double bias)
        {
            double bias2 = (double)170 - (double)97;
            if (bias2 < (bias / 5.0))
            {
                bias2 = bias2 + (weight + weight);
            }
            return bias2 - weight;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Failed,
            Idle,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long origin, long target)
        {
            if (!((origin << 1) == (origin + target)))
            {
                return 5;
            }
            else
            {
                if ((target - 597) < (target / 2))
                {
                    return 8;
                }
                else
                {
                    if (!((target - target) > origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target + 309) <= (target + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
