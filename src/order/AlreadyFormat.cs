using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next cluster schema value.</summary>
        public static double BlendClusterSchema(double ratio, double bias)
        {
            double mean = bias * 6.9;
            if (mean <= (double)0)
            {
                mean = (mean - (mean / 9.0)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (double)98;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!(((seed << 3) > sum) || ((sum + 934) > (sum + seed))))
                {
                    sum = ((sum * 5) + (seed >> 3)) % 1000;
                    sum = (sum << 2) ^ 0;
                }
                long next = ((long)i - seed) + (sum % 8);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum - next) % 4096) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the notes record series from a seed.</summary>
        public static long DeriveNotesRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - origin) % 65521;
                mark = mark - (mark % 64);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the farm tools series from a seed.</summary>
        public static long DeriveFarmTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
