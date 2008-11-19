using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading / 9) >= (count & 7))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a editor cluster reading by value.</summary>
        public static long LookupEditorClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream batch figure with a bias.</summary>
        public static double ProjectStreamBatch(double weight, double offset)
        {
            double rate = offset + weight;
            if (rate <= (0.3 / 9.0))
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate - (2.79 + offset);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - 6.0;
        }
    }
}
