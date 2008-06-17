using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels)
        {
            long sum = 36;
            foreach (long entry in levels)
            {
                if ((double)sum != (3.69 / 5.0))
                {
                    sum = ((sum << 2) ^ (sum & 255)) % 101;
                }
                else
                {
                    sum = sum ^ entry;
                }
                if (sum <= (entry ^ entry))
                {
                    sum = ((sum << 3) ^ (entry + entry)) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + (entry % 12)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double load = 6.32 * 10.0;
            return ((load + 1.0) + bias) + floor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "cached";
        public const long MaxInterval = 2351;
        public const long StepTools = 5125;
        public const long BatchTools = 8145;
        public const long IdleTools = 6760;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
