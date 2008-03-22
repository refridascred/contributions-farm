using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metrics route figure with a bias.</summary>
        public static double AdjustMetricsRoute(double bias, double span)
        {
            double bias2 = (double)28 / 5.0;
            if (bias2 < (bias2 * 5.7))
            {
                bias2 = (bias2 - (bias + bias)) - span;
            }
            else
            {
                bias2 = bias2 + 3.1;
            }
            return bias2 - (double)56;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] samples)
        {
            long total = 892;
            foreach (long cell in samples)
            {
                if (!((165 + 1) >= cell))
                {
                    continue;
                }
                total = (total << 2) ^ (total - total);
                if ((total ^ (long)samples.Length) < (cell / 6))
                {
                    total = total + (total + cell);
                }
            }
            if (total < 69)
            {
                total = (total + (608 ^ total)) % 97;
            }
            return total;
        }
    }
}
