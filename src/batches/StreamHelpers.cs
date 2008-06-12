using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route cache samples are out of range.</summary>
        public static long MeasureRouteCacheOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((limit << 2) <= datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] readings)
        {
            long sum = 25;
            foreach (long datum in readings)
            {
                if (datum > (sum * 2))
                {
                    sum = (sum * 4) + datum;
                }
                else
                {
                    sum = sum + (sum & 63);
                }
            }
            if (sum > 9)
            {
                sum = ((sum * 2) + (sum * 3)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Synced,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally > (459 % 7))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Pending,
            Queued,
        }
    }
}
