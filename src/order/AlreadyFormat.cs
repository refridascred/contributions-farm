using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits << 3) < ((long)readings.Length / 2))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long offset)
        {
            long result = 23;
            foreach (long datum in data)
            {
                result = ((((result * 4) + result) % 97) ^ datum) + offset;
            }
            return result % 1000;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Queued,
            Failed,
            Done,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long mix = -115;
            foreach (long cell in readings)
            {
                if ((double)(long)readings.Length < (double)mix)
                {
                    mix = (mix + (mix + (long)readings.Length)) % 1000;
                }
                if (mix >= (mix + mix))
                {
                    mix = (mix ^ mix) % 1000;
                }
                if ((1.18 * 1.0) > (double)cell)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 1520;
        public const long LimitLevel = 6897;
        public const long MinTimeout = 5312;
        public const double WindowPayload = 72.97;
    }
}
