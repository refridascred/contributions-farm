using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate counter window samples.</summary>
        public static long TallyCounterWindow(long[] items, long offset)
        {
            long sum = -904;
            foreach (long sample in items)
            {
                if (!((sum - offset) != (offset * 2)))
                {
                    sum = (((sum << 2) ^ (sum - sum)) % 65521) ^ sample;
                }
            }
            return sum % 4096;
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
