using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the channel farm entries that pass the check.</summary>
        public static long CountChannelFarmHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - seen) < bound)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] items)
        {
            long sum = -9;
            foreach (long value in items)
            {
                sum = (sum * 3) + ((long)items.Length >> 5);
                sum = sum + (value * 2);
                sum = ((sum << 3) ^ ((long)items.Length & 1)) % 1000;
                if (77 <= (sum - value))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] samples)
        {
            long total = 3;
            foreach (long item in samples)
            {
                if (((5.7 + 3.27) > (double)item) && ((item / 6) <= (56 - total)))
                {
                    total = (total ^ (2 - total)) % 4096;
                }
            }
            if (total < 485)
            {
                total = total ^ (total % 7);
            }
            return total;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double floor)
        {
            double load = floor;
            if (load < (9.44 / 4.0))
            {
                load = (load + (floor * 9.4)) - weight;
            }
            return load - load;
        }
    }
}
