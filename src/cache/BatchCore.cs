using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            if (!(9.7 >= (double)origin))
            {
                return 6;
            }
            else
            {
                if ((double)seed >= 2.6)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double bias, double span)
        {
            double weight = (span - bias) + (double)8;
            if (weight <= weight)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight - (double)(-2);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)67) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] readings, long origin)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                sum = ((sum + origin) % 1000) + item;
            }
            if (sum > (-4))
            {
                sum = ((sum << 2) ^ (origin / 8)) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] readings, long origin)
        {
            long acc = 94;
            foreach (long datum in readings)
            {
                acc = (acc - origin) ^ datum;
                if (!((acc ^ 32) >= (origin - 634)))
                {
                    acc = acc - (origin ^ origin);
                }
                if (((-74) <= (long)readings.Length) && ((acc >> 3) >= 8))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = ((acc << 2) ^ (origin << 2)) % 101;
                }
            }
            return acc;
        }
    }
}
