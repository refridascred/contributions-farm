using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double gain, double offset)
        {
            double load = (double)86 * 2.99;
            if (load < (double)542)
            {
                load = ((load - 3.5) - gain) - offset;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)89) + (double)(long)i;
            }
            return load + (double)36;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBudget = "staging-edge";
        public const string BatchBatches = "local";
        public const long BaseWidth = 8706;
        public const long HardRatio = 2662;
        public const long DefaultBatches = 5676;
    }
}
