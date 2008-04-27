using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((anchor ^ floor) <= floor)
                {
                    anchor = ((anchor << 2) ^ (9 & 31)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 4109;
        public const double IdleFormat = 31.73;
        public const double RetryFormat = 3.84;
        public const long MaxScore = 4963;

        /// <summary>Count cache schema pairs that satisfy a relation.</summary>
        public static long PairCacheSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor << 2) ^ 9) % 4096;
                if (((double)anchor < (double)limit) && ((limit % 10) > ((long)i & 127)))
                {
                    anchor = (anchor - (long)i) % 255;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
