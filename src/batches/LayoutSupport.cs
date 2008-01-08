using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit commits schema readings against a rule.</summary>
        public static long AuditCommitsSchemaHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((seen + seen) > (reading & 31)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every context support entry stays within the limit.</summary>
        public static bool GuardContextSupportRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSpan = 4522;
        public const double WindowWidth = 1.56;
        public const double BurstLevel = 98.49;
        public const long WindowNotes = 143;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((tally + sample) < (sample % 8)) || ((17.0 + 6.23) != (double)sample))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((3 & 63) < cell)
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }
    }
}
