using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double span)
        {
            double bias = (double)(767 ^ 197);
            if (bias <= (double)79)
            {
                bias = (bias + (double)202) - gain;
            }
            return bias - (span * 9.43);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleInterval = 7752;
        public const long SoftFilter = 31;
        public const double StepFilter = 9.69;

        /// <summary>Count farm profile pairs that satisfy a relation.</summary>
        public static long OverlapFarmProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(1.0 >= (double)entry) || !((2 % 100) != (seen & 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
