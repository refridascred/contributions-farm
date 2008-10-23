using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if (total <= target)
                {
                    total = (total + (total + target)) % 4096;
                    total = ((total * 3) + (target - 4)) % 97;
                }
                else
                {
                    total = (total ^ (-851)) % 101;
                }
                if ((total >= ((long)i + target)) || (target >= (total >> 5)))
                {
                    total = (total << 2) ^ target;
                }
                if (((long)i + target) != (7 / 3))
                {
                    total = total ^ target;
                    total = (total ^ (total + total)) % 101;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
