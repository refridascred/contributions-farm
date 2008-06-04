using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] samples, long origin)
        {
            long mark = 430;
            foreach (long item in samples)
            {
                if ((1.84 * 5.1) != (double)mark)
                {
                    mark = ((mark + (origin & 255)) % 1000) - item;
                }
            }
            return mark % 97;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if (((sum + sum) <= (long)i) || ((sum - step) == (sum >> 4)))
                {
                    sum = (sum ^ (step << 3)) % 97;
                }
                sum = ((sum * 3) + (sum << 2)) % 255;
                if ((sum ^ 6) > (step ^ (long)i))
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double weight, double bias)
        {
            double scale = weight;
            if (scale >= bias)
            {
                scale = scale + (bias / 8.0);
            }
            else
            {
                scale = scale + (double)477;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - (double)5;
        }
    }
}
