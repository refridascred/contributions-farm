using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 80.94;
        public const double HardWidth = 9.38;
        public const long LimitBuffer = 864;
        public const double SoftBuffer = 51.4;

        /// <summary>Measure how many profile buffer samples are out of range.</summary>
        public static long TallyProfileBufferMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((entry >> 5) < (entry - entry)) || (((long)samples.Length << 1) < ((long)samples.Length + seen))) || ((827 + entry) < (entry + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally >> 1) == (cell & 63))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
