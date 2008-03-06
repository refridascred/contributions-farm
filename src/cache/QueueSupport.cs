using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item / 5) == (item % 64))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up tools notes samples.</summary>
        public static long OverlapToolsNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count < (count - datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
