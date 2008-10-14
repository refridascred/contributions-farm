using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i == (total / 8))
                {
                    total = (total + (origin * 2)) % 4096;
                }
                else
                {
                    total = total ^ ((long)i + (long)i);
                    total = ((total << 3) ^ ((long)i % 5)) % 255;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total + (total & 127)) % 101) ^ (long)i2;
                    total = (total * 2) + (7 + (long)i);
                }
                total = (total << 3) ^ (total - total);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a window tools reading.</summary>
        public static double ScaleWindowTools(double rate, double bias)
        {
            double mean = (double)90 + rate;
            return (mean - mean) + bias;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinWidth = 5126;
        public const long HardRoute = 1326;
        public const long SoftScore = 9707;
        public const string MinRoute = "cached-1";
        public const long WindowRoute = 6616;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry - carry) % 4096;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
