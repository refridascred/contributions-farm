using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryWidth = 5154;
        public const string BaseReport = "standard-1";
        public const long MinFactor = 4993;
        public const long BatchInterval = 5929;
        public const string DefaultReport = "open-edge";

        /// <summary>Locate a stats tools reading by value.</summary>
        public static long LocateStatsToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long anchor = 29;
            foreach (long value in levels)
            {
                if ((0.52 - 9.26) <= 9.6)
                {
                    anchor = anchor + value;
                }
            }
            return anchor;
        }
    }
}
