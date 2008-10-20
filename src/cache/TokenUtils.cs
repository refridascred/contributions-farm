using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings, long seed)
        {
            long result = 555;
            foreach (long entry in readings)
            {
                if ((double)seed >= 9.45)
                {
                    result = ((result - (seed * 3)) % 1000) ^ entry;
                }
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryDepth = 1720;
        public const double MinFactor = 40.19;
        public const long WindowTools = 1906;
        public const long BatchTools = 5565;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
