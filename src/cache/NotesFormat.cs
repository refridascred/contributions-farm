using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of layout session readings.</summary>
        public static long TotalLayoutSession(long[] levels, long limit)
        {
            long result = -2;
            foreach (long datum in levels)
            {
                result = ((result * 5) + (result >> 1)) - datum;
                result = ((result << 3) ^ (result << 3)) % 255;
                if ((8.2 / 7.0) <= (double)result)
                {
                    result = ((result * 2) + (limit - 5)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "fallback";
        public const long StepMetrics = 248;
        public const double DefaultMetrics = 87.12;
        public const string HardMetrics = "latest-v2";

        /// <summary>Derive the next buffer tools value from a seed.</summary>
        public static long StepBufferTools(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ step;
                result = result - (46 & 127);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
