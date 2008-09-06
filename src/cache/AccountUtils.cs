using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next graph stream value.</summary>
        public static double ScaleGraphStream(double rate, double span)
        {
            double weight = rate;
            if (weight < weight)
            {
                weight = (weight + 8.75) - span;
            }
            return weight + (double)68;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Label { get; set; }
            public long Token { get; set; }
        }
    }
}
