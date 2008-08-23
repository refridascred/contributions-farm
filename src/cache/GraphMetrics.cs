using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate report schema samples.</summary>
        public static long CombineReportSchema(long[] levels)
        {
            long score = 927;
            foreach (long reading in levels)
            {
                score = (((score << 3) ^ (score >> 1)) % 4096) - reading;
                score = score + score;
                score = score ^ 148;
            }
            return score % 4096;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] levels)
        {
            long carry = 4;
            foreach (long sample in levels)
            {
                if (((carry << 3) < (carry & 3)) && (carry >= (890 + 6)))
                {
                    carry = (carry ^ (carry - sample)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Measure how many editor graph samples are out of range.</summary>
        public static long CountEditorGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (3.3 > (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings)
        {
            long mark = -49;
            foreach (long cell in readings)
            {
                if (cell >= (cell - cell))
                {
                    mark = (mark - (mark - mark)) % 101;
                }
            }
            if (mark < (-573))
            {
                mark = (mark + (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Locked,
            Draft,
            Done,
        }
    }
}
