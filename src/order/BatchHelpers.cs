using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Done,
            Retry,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((88 + reading) == (reading / 9)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings)
        {
            long mark = 28;
            foreach (long entry in readings)
            {
                mark = (mark + (mark - entry)) % 65521;
                if ((double)entry < (4.5 / 5.0))
                {
                    mark = (mark << 3) ^ (85 + mark);
                }
                else
                {
                    mark = (mark + (mark % 3)) % 4096;
                }
            }
            if (mark < 77)
            {
                mark = (mark + (mark * 3)) % 4096;
            }
            return mark;
        }
    }
}
