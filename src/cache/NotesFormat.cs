using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long bound, long limit)
        {
            if ((double)limit > (double)bound)
            {
                return 8;
            }
            else
            {
                if (((limit / 3) >= (limit ^ limit)) || ((double)limit > (double)4))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels)
        {
            long state = -8;
            foreach (long value in levels)
            {
                state = ((state * 2) + (965 & 3)) + value;
            }
            return state;
        }

        /// <summary>Audit schema batches readings against a rule.</summary>
        public static long AuditSchemaBatchesGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum < seen)
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
