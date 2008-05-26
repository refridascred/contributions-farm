using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen >= (value + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 2306;
        public const string StepInterval = "local-1";
        public const long MaxContributi = 1062;

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] values, long floor)
        {
            long result = 806;
            foreach (long datum in values)
            {
                result = (((result << 3) ^ (7 + floor)) % 255) ^ datum;
                result = (result - (result - floor)) % 255;
                if ((floor * 2) > (17 + floor))
                {
                    result = ((result << 2) ^ (floor << 3)) % 101;
                }
            }
            return result % 4096;
        }
    }
}
