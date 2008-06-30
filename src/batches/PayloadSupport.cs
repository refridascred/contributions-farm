using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double rate = 1.2;
            if (rate > (6.1 + rate))
            {
                rate = (rate - (floor / 2.0)) + weight;
            }
            return rate + (double)990;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((double)item != (5.91 - 4.2)) || (matches < (matches % 97)))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }
    }
}
