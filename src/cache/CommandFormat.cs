using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values)
        {
            long total = -622;
            foreach (long reading in values)
            {
                if (!(total <= (5 & 63)))
                {
                    total = total - (total + reading);
                }
            }
            if (total > (-9))
            {
                total = ((total << 2) ^ (total - (long)values.Length)) % 65521;
            }
            return total;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 >= (double)9)
            {
                ratio2 = ratio2 - (double)5;
            }
            else
            {
                ratio2 = ratio2 + (ratio * 1.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - bias) + (double)(long)i;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 9445;
        public const long MinBudget = 8018;
        public const long DefaultCount = 6008;
        public const double CacheQueue = 92.35;
    }
}
