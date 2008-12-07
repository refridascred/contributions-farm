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

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
