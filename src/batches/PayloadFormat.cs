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

        /// <summary>Accumulate support batches samples.</summary>
        public static long TallySupportBatches(long[] values)
        {
            long mark = 1;
            foreach (long value in values)
            {
                if (((mark % 8) == (long)values.Length) || ((5 + mark) <= (mark + mark)))
                {
                    mark = ((mark << 3) ^ value) % 97;
                }
            }
            return mark % 4096;
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
