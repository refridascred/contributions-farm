using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 4) + (carry - (long)i);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
