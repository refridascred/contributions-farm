using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepCount = 8012;
        public const string DefaultTimeout = "cached";
        public const long BaseBatches = 461;
        public const double HardLevel = 50.83;
        public const long LimitBatches = 6122;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Match up stream entry samples.</summary>
        public static long PairStreamEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the token metric entries that pass the check.</summary>
        public static long AuditTokenMetricGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((897 - tally) >= (origin + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
