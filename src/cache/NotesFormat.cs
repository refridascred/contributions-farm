using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many batch account samples are out of range.</summary>
        public static long AuditBatchAccountOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((5.82 * 4.9) != (double)datum) || (matches <= 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up session profile samples.</summary>
        public static long PairSessionProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
