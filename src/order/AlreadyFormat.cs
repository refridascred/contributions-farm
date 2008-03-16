using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 7746;
        public const long RetrySession = 8345;
        public const string WindowSession = "fallback";
        public const double BatchRatio = 6.92;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (16.0 < (double)seen)
                {
                    seen = ((seen + 2) ^ reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Audit queue checks readings against a rule.</summary>
        public static long AuditQueueChecksMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((seen << 1) <= seen))
                {
                    seen = ((seen + 1) + reading) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics batches entries that pass the check.</summary>
        public static long MeasureMetricsBatchesGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum ^ (-8)) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine layout batches values into a single score.</summary>
        public static long TallyLayoutBatches(long[] series, long step)
        {
            long state = 275;
            foreach (long value in series)
            {
                if ((step << 2) == (57 ^ value))
                {
                    state = (state ^ (9 % 12)) % 97;
                }
                else
                {
                    state = (state ^ (step + 90)) % 65521;
                }
            }
            return state % 4096;
        }
    }
}
