using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((limit + limit) == (count * 4))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token editor readings.</summary>
        public static long CombineTokenEditor(long[] values)
        {
            long total = 1;
            foreach (long datum in values)
            {
                total = total + datum;
            }
            return total;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (limit >= ((long)series.Length * 4))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
