using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "local-edge";
        public const double BaseCount = 33.0;
        public const long StepSchema = 4770;
        public const string CacheLevel = "stable";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((cell <= (8 << 3)) && ((cell >> 4) < seen)) && (((double)seen > (4.0 * 6.4)) && ((seen - cell) == (cell * 3))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next entry account value from a seed.</summary>
        public static long StepEntryAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = mix + (1 + limit);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
