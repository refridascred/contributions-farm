using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = sum ^ (long)i2;
                    sum = (sum << 2) ^ limit;
                }
                if ((sum % 5) < ((long)i >> 1))
                {
                    sum = ((sum << 2) ^ limit) % 65521;
                    sum = sum - sum;
                }
                if ((((-824) - limit) < sum) || (limit > (30 + limit)))
                {
                    sum = (sum - ((long)i & 7)) % 255;
                }
                else
                {
                    sum = (sum ^ (limit + sum)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double load = (span + span) / 9.0;
            if (load >= gain)
            {
                load = load + (load * 1.4);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (gain / 8.0)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double rate = floor;
            if (rate > (double)(-20))
            {
                rate = (rate - rate) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (5.0 * 7.0)) + (double)(long)i;
            }
            return rate - (double)80;
        }
    }
}
