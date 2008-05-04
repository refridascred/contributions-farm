using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double offset)
        {
            double load = (double)((-11) * 5);
            return (load + bias) + offset;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                if ((target * 2) < (long)i)
                {
                    result = (result ^ (long)i) % 101;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the record stats series from a seed.</summary>
        public static long StepRecordStats(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                if (2 >= (origin - sum))
                {
                    sum = (sum - (sum << 1)) % 1000;
                    continue;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum << 3) ^ (long)i) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double bias, double offset)
        {
            double rate = offset;
            if (rate < rate)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate + (bias + rate);
            }
            return rate - bias;
        }
    }
}
