using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 65.67;
        public const long HardReport = 933;
        public const string SoftReport = "legacy-edge";
        public const long IdleDepth = 9162;

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine channel counter values into a single score.</summary>
        public static long TotalChannelCounter(long[] values)
        {
            long anchor = 9;
            foreach (long reading in values)
            {
                if ((double)reading > (1.35 / 8.0))
                {
                    anchor = anchor + ((long)values.Length % 3);
                }
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 5347;
        public const long WindowFactor = 2223;
        public const long MinRatio = 6494;
        public const long SoftContext = 6719;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
