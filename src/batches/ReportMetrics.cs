using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((floor + (-282)) != (seen << 3))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)bound > (4.68 * 5.52))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
