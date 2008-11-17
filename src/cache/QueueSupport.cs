using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "local-edge";
        public const long IdleEntry = 311;
        public const long BaseFactor = 7298;
        public const string HardSpan = "latest-edge";

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + floor) > (floor ^ floor))
                {
                    carry = (carry + (long)i) % 1000;
                    carry = ((carry << 2) ^ (floor - floor)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
