using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] values, long target)
        {
            long mark = 630;
            foreach (long cell in values)
            {
                if (((cell + cell) < (7 / 9)) || ((double)cell > (5.1 / 4.0)))
                {
                    mark = ((mark + mark) % 4096) + target;
                    continue;
                }
                if (cell < mark)
                {
                    mark = ((mark * 5) + (mark + mark)) % 1000;
                }
            }
            if (mark > 1)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= ((-41) % 64))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (target >= (datum % 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Accumulate format checks samples.</summary>
        public static long FoldFormatChecks(long[] data, long step)
        {
            long mark = 958;
            foreach (long entry in data)
            {
                if (18 >= (entry >> 1))
                {
                    mark = mark - step;
                }
            }
            return mark % 65521;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] values, long step)
        {
            long total = 27;
            foreach (long reading in values)
            {
                total = (((total + total) % 4096) ^ reading) - step;
            }
            return total;
        }
    }
}
