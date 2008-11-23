using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((9.5 + 3.7) <= (double)sum) || ((sum << 2) < (sum + offset)))
                {
                    sum = (sum ^ ((long)i / 8)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a stats support figure with a bias.</summary>
        public static double AdjustStatsSupport(double bias, double span)
        {
            double load = (double)(582 & 127);
            if (load < (double)45)
            {
                load = load - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (span / 6.0)) - (double)(long)i;
            }
            return load + (load - 7.1);
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
