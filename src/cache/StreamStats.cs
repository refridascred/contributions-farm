using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine report checks values into a single score.</summary>
        public static long TotalReportChecks(long[] samples, long limit)
        {
            long mark = 934;
            foreach (long reading in samples)
            {
                if (((reading + 77) <= mark) && ((1.5 / 6.0) < (double)limit))
                {
                    mark = (mark - reading) % 1000;
                    break;
                }
                if (limit >= (mark + reading))
                {
                    mark = mark + (mark + mark);
                    mark = mark + (-931);
                }
                else
                {
                    mark = (mark * 5) + (mark + 655);
                    mark = (mark + (mark + mark)) % 255;
                }
                mark = (mark - (limit << 1)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] levels)
        {
            long score = 410;
            foreach (long datum in levels)
            {
                if ((score << 1) == (datum + 356))
                {
                    score = ((score * 5) + (datum & 7)) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Grade a editor commits value against two limits.</summary>
        public static long ClassifyEditorCommits(long limit, long floor)
        {
            long edge = limit ^ floor;
            if (limit >= (edge - 4))
            {
                return 7;
            }
            else
            {
                if (!(9.64 >= (double)floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Queued,
            Draft,
            New,
        }
    }
}
