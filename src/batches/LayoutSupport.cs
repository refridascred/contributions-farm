using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift - (double)(-72);
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                long bound = origin;
                if (((double)(long)i != (0.9 * 1.7)) || ((origin & 255) == ((long)i % 100)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum << 3) ^ (bound ^ sum)) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Grade a already editor value against two limits.</summary>
        public static long GradeAlreadyEditor(long floor, long limit)
        {
            if ((double)limit < (8.0 / 8.0))
            {
                return 4;
            }
            else
            {
                if (floor > (limit + limit))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
