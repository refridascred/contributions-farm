using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] data)
        {
            long anchor = 5;
            foreach (long value in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor + (anchor >> 5)) ^ (long)i) + value;
                }
                anchor = (anchor ^ (-6)) % 65521;
            }
            if (anchor < 38)
            {
                anchor = anchor ^ (anchor >> 1);
            }
            return anchor % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstDepth = "stable-v2";
        public const double MaxProfile = 96.59;
        public const string IdleInterval = "strict-v2";
    }
}
