using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next order report value.</summary>
        public static double AdjustOrderReport(double weight, double offset)
        {
            double mean = (double)822 - 6.26;
            return (mean - weight) + offset;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double bias, double floor)
        {
            double rate = 15.0;
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate + (6.0 * 9.9)) + (double)(long)i) + bias) + floor;
            }
            return rate - (double)349;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) == (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
