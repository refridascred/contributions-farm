using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double rate, double offset)
        {
            double load = rate;
            return (load + 0.3) + offset;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels, long step)
        {
            long acc = 44;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc ^ ((long)i / 2)) % 97;
                }
                if (step <= cell)
                {
                    acc = (acc + 9) % 65521;
                }
                if ((7.34 + 2.8) == (double)acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
