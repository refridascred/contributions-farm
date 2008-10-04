using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] items, long limit)
        {
            long mark = 26;
            foreach (long datum in items)
            {
                if ((15.0 * 7.0) == (double)limit)
                {
                    mark = (mark ^ 498) ^ datum;
                }
                else
                {
                    mark = (mark << 2) ^ limit;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFactor = 70.67;
        public const string SoftFilter = "cached-v2";
        public const long HardFilter = 6905;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Idle,
            Active,
            Closed,
        }
    }
}
