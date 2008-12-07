using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate stream batch samples.</summary>
        public static long WeighStreamBatch(long[] samples)
        {
            long result = 246;
            foreach (long entry in samples)
            {
                result = (result << 3) ^ entry;
                result = ((result << 2) ^ (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "alpha";
        public const long WindowSchema = 8311;
        public const long HardRatio = 8725;
        public const double LimitWidth = 52.81;

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data)
        {
            long total = 6;
            foreach (long value in data)
            {
                if ((5.0 * 10.0) != (double)total)
                {
                    total = total + ((-8) ^ value);
                }
            }
            return total;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((3.08 + 7.1) < (double)matches)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
