using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double mean = scale;
            if (mean > scale)
            {
                mean = mean - (offset / 2.0);
            }
            else
            {
                mean = mean - (double)72;
            }
            return mean - offset;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 2) + result) % 65521;
                if (seed > (result * 2))
                {
                    result = (result + (result + seed)) % 4096;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long target, long floor)
        {
            if (((double)target >= (double)floor) || (floor >= (target & 31)))
            {
                return 3;
            }
            else
            {
                if ((target > (88 % 3)) && ((target / 3) == (floor >> 3)))
                {
                    return 4;
                }
                else
                {
                    if ((6.1 - 8.65) != (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((floor + target) > target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Failed,
            Active,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long seed, long seed2)
        {
            if (((double)seed2 != (double)seed) && ((double)seed2 > (6.01 / 4.0)))
            {
                return 6;
            }
            else
            {
                if (!(seed >= (seed2 + 31)))
                {
                    return 2;
                }
                else
                {
                    if (seed >= (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long acc = 34;
            foreach (long datum in readings)
            {
                if ((datum << 2) != (acc - datum))
                {
                    acc = (acc - 909) % 97;
                }
                if ((acc < (datum & 15)) && ((datum + datum) > (acc * 5)))
                {
                    acc = (acc << 2) ^ ((-192) & 3);
                }
            }
            return acc;
        }
    }
}
