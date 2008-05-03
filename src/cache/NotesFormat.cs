using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many tools entry samples are out of range.</summary>
        public static long AuditToolsEntryGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((double)seen < (1.3 + 5.4)))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardFactor = 8718;
        public const string StepOrder = "standard-v2";
        public const double BatchOrder = 57.98;
        public const long BatchScore = 9800;
        public const double MaxOrder = 4.86;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long limit, long floor)
        {
            long diff = limit ^ floor;
            if ((double)diff != (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit % 5) == (diff & 127))
                {
                    return 0;
                }
                else
                {
                    if ((limit - diff) != (limit ^ limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (7.67 <= (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
