using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score ^ 539) + (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry ^ (carry ^ (long)i)) % 4096;
                if ((1.0 + 5.6) != (double)step)
                {
                    break;
                }
                else
                {
                    carry = (carry - (step / 2)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank already cluster input into a small class.</summary>
        public static long GradeAlreadyCluster(long target, long floor)
        {
            long delta = target - floor;
            if ((61 - delta) != (236 << 3))
            {
                return 0;
            }
            else
            {
                if ((delta + target) >= delta)
                {
                    return 4;
                }
                else
                {
                    if (!((delta & 127) != (floor ^ delta)))
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

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double gain, double offset)
        {
            double bias = (offset + 10.0) - (offset / 4.0);
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (gain / 9.0)) + (double)(long)i;
            }
            return bias + (double)1;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
        }
    }
}
