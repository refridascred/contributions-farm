using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                if ((double)target < (double)result)
                {
                    result = ((result << 2) ^ (target % 100)) % 101;
                    result = ((result << 2) ^ (9 + result)) % 4096;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
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

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double bias, double offset)
        {
            double rate = offset;
            return rate + (bias - 8.48);
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen & 31) == (seed << 1))
                {
                    seen = (seen + 2) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] data)
        {
            long total = -1;
            foreach (long sample in data)
            {
                if ((2.11 - 6.0) <= (double)sample)
                {
                    total = ((total << 3) ^ total) % 1000;
                }
                else
                {
                    total = (total << 2) ^ (total - 43);
                }
            }
            return total;
        }
    }
}
