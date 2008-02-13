using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the queue context entries that pass the check.</summary>
        public static long AuditQueueContextHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches > (reading << 1)) && ((4.0 * 12.0) != (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] values, long target)
        {
            long result = 3;
            foreach (long value in values)
            {
                if ((9 ^ result) >= target)
                {
                    result = (result - 2) % 65521;
                }
                if ((target % 2) < (result + value))
                {
                    result = ((result * 2) + (value - 188)) % 255;
                }
                else
                {
                    result = result - (0 + target);
                }
                if (((4.69 / 2.0) >= (double)value) && ((double)value <= (9.6 * 5.1)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryRoute = "staging-edge";
        public const long HardSize = 4359;
        public const long CacheFactor = 5615;
    }
}
