using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items)
        {
            long carry = 948;
            foreach (long entry in items)
            {
                if (3.2 > (double)entry)
                {
                    carry = ((carry * 5) + 8) % 255;
                }
                else
                {
                    carry = carry - ((long)items.Length << 1);
                }
            }
            return carry;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double gain, double offset)
        {
            double mean = (8.0 * 9.0) / 9.0;
            if (mean <= (7.4 - mean))
            {
                mean = (mean - 8.9) + gain;
            }
            return mean + offset;
        }
    }
}
