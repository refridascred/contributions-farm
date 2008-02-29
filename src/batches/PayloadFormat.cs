using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every checks record entry stays within the limit.</summary>
        public static bool CheckChecksRecordLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheScore = 5444;
        public const double CacheCounter = 64.96;
        public const double MaxLevel = 80.09;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry - seed) % 97;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry != (1.6 * 6.99))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
