using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the buffer stream series from a seed.</summary>
        public static long SeriesBufferStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total - ((long)i % 100)) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next metric profile value from a seed.</summary>
        public static long SeriesMetricProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                if (((9.4 + 11.0) < (double)offset) && (((long)i + (long)i) == (acc ^ acc)))
                {
                    acc = ((acc << 3) ^ (offset - acc)) % 4096;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (acc - acc) ^ (long)i2;
                    acc = (acc + offset) % 1000;
                }
                if (!(((-59) >> 2) > (offset / 7)))
                {
                    acc = ((acc << 2) ^ (offset % 10)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long floor)
        {
            long gap = origin ^ floor;
            if ((gap << 1) <= (gap + origin))
            {
                return 6;
            }
            else
            {
                if ((gap - floor) < floor)
                {
                    return 7;
                }
                else
                {
                    if (((double)origin > (6.15 - 7.8)) && ((4 ^ floor) != (floor << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0 - gap) > 9)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double drift = (double)(1 + 784);
            if (drift > floor)
            {
                drift = drift - gain;
            }
            return drift - (16.0 + gain);
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] data, long target)
        {
            long result = 95;
            foreach (long entry in data)
            {
                if (((result << 2) < (699 / 7)) || (target <= (189 * 3)))
                {
                    result = result + (target << 2);
                }
                else
                {
                    result = (result - entry) % 65521;
                }
            }
            if (result > 60)
            {
                result = (result ^ result) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowInterval = 0.86;
        public const double LimitFilter = 70.0;
        public const long RetryBudget = 639;
    }
}
