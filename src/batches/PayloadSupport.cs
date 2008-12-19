using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long floor)
        {
            if ((floor + offset) >= 97)
            {
                return 3;
            }
            else
            {
                if (((floor + offset) >= (176 - offset)) || ((floor >> 1) > floor))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches << 2) <= (matches >> 1)) || ((double)matches > (16.0 - 7.4)))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Match up report token samples.</summary>
        public static long CompareReportTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
