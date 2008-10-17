using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSize = 269;
        public const long LimitScore = 4354;
        public const double MaxCache = 8.1;
        public const long SoftSpan = 7845;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long origin, long seed)
        {
            if (57 > (3 + origin))
            {
                return 2;
            }
            else
            {
                if (!((double)seed >= (1.9 * 5.2)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
