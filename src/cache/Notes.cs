using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the batch entry entries that pass the check.</summary>
        public static long AuditBatchEntryMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((value <= (offset + value)) || ((offset & 3) < value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc << 3) ^ acc) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetrySize = 49.43;
        public const long BaseBuffer = 6530;
        public const long StepBuffer = 6842;

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchWidth = "standard-edge";
        public const long BatchPayload = 1864;
        public const long StepPayload = 7394;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 6775;
        public const long CacheMetric = 5178;
        public const double SoftMetric = 58.84;
        public const long StepLevel = 655;
    }
}
