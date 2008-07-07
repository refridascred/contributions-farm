using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long MeasureFarmGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((2.99 - 2.0) >= (double)seen))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 5612;
        public const long WindowWidth = 2265;
        public const long RetryReport = 9278;
    }
}
