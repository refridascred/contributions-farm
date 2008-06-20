using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((20.0 / 8.0) != (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (59 <= (origin + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
