using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((5.5 - 9.2) >= (double)reading)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "open-edge";
        public const long MaxChannel = 48;
        public const long BaseChannel = 1571;

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 56.95;
        public const long BaseRecord = 1963;
        public const long BurstRecord = 3488;
        public const string IdleRecord = "fallback-1";
        public const long HardCount = 6842;
    }
}
