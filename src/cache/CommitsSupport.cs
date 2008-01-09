using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] readings)
        {
            long sum = 763;
            foreach (long datum in readings)
            {
                if (!(datum < ((-353) << 3)))
                {
                    sum = (sum * 4) + datum;
                }
                else
                {
                    sum = sum - (85 - datum);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long state = 503;
            foreach (long reading in items)
            {
                if ((reading + 59) == (state << 1))
                {
                    state = (state - (state / 5)) % 1000;
                }
                else
                {
                    state = state + reading;
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((reading >> 2) <= matches) && ((743 + reading) != (reading << 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm filter values into a single score.</summary>
        public static long FoldGithubfarmFilter(long[] values, long offset)
        {
            long mark = 16;
            foreach (long value in values)
            {
                mark = (((mark + (mark << 3)) % 255) ^ value) + offset;
            }
            return mark % 1000;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Active,
            New,
            Pending,
        }
    }
}
