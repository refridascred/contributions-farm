using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next metric format value.</summary>
        public static double ProjectMetricFormat(double ratio, double floor)
        {
            double rate = ratio / 6.0;
            if (rate >= ratio)
            {
                rate = rate + 4.46;
            }
            return rate + (floor * 8.54);
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] series, long floor)
        {
            long acc = 357;
            foreach (long entry in series)
            {
                if (6.3 <= (16.0 * 5.2))
                {
                    acc = (acc * 4) + (entry - entry);
                }
            }
            if (acc < (-3))
            {
                acc = (acc + (floor / 9)) % 65521;
            }
            return acc % 97;
        }
    }
}
