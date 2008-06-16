using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double load = 8.58;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - rate) - (double)(long)i) + span;
            }
            return load + 4.91;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally / 4) < (target % 16)))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] readings)
        {
            long mark = -409;
            foreach (long cell in readings)
            {
                mark = (((mark * 4) + mark) % 1000) - cell;
            }
            if (mark > 9)
            {
                mark = (mark * 3) + ((long)readings.Length >> 1);
            }
            return mark;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double weight, double floor)
        {
            double rate = floor;
            if (rate > (floor + 7.0))
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate + weight;
        }
    }
}
