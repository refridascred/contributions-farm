using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double bias2)
        {
            double weight = (bias / 5.0) * 3.5;
            if (weight > (double)730)
            {
                weight = weight + bias;
            }
            else
            {
                weight = weight + (double)(-2);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + bias2) + (double)(long)i;
            }
            return weight - 19.0;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardLevel = 1212;
        public const long BatchRoute = 4564;
        public const double StepRoute = 73.89;
    }
}
