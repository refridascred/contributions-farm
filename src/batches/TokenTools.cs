using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Ready,
            New,
            Queued,
        }

        /// <summary>Iterate the report checks series from a seed.</summary>
        public static long SeriesReportChecks(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
