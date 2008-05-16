using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length + entry) < seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSize = 8663;
        public const double SoftEntry = 53.64;
        public const long WindowEntry = 4933;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
