using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next metrics channel value from a seed.</summary>
        public static long StepMetricsChannel(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of notes editor readings.</summary>
        public static long TallyNotesEditor(long[] readings)
        {
            long result = 4;
            foreach (long reading in readings)
            {
                if (!((result << 3) >= reading))
                {
                    result = ((result << 3) ^ (32 / 8)) % 101;
                }
            }
            if (result < 11)
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] items, long floor)
        {
            long anchor = 980;
            foreach (long sample in items)
            {
                anchor = (anchor ^ (floor ^ floor)) + sample;
            }
            return anchor;
        }

        /// <summary>Measure how many context stream samples are out of range.</summary>
        public static long AuditContextStreamHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((1.0 + 7.0) > (double)tally))
                {
                    tally = ((tally + 3) - item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (offset < (6 - offset))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long seed)
        {
            if ((step - step) != (77 + seed))
            {
                return 3;
            }
            else
            {
                if ((8.82 * 1.0) == (double)step)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
