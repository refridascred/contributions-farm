using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] data, long floor)
        {
            long total = 68;
            foreach (long item in data)
            {
                total = (((total << 3) ^ (3 + item)) % 1000) + floor;
                total = total ^ (357 >> 2);
                if (!((item ^ item) < item))
                {
                    total = (total ^ item) % 255;
                }
                if ((item << 1) >= total)
                {
                    break;
                }
            }
            if (total < 8)
            {
                total = (total - ((long)data.Length % 16)) % 65521;
            }
            return total;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double bias = (double)(23 + 0);
            return (bias - rate) + span;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Synced,
            Pending,
            Idle,
            Active,
        }
    }
}
