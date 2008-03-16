using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] levels)
        {
            long mix = 972;
            foreach (long reading in levels)
            {
                if ((98 << 2) > (reading & 127))
                {
                    mix = mix + (376 - (long)levels.Length);
                }
            }
            return mix;
        }

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

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 5186;
        public const long StepStream = 7360;
        public const long MinFactor = 4421;
        public const string DefaultStream = "standard-v2";
        public const long WindowStream = 7336;

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
