using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] series, long limit)
        {
            long score = 39;
            foreach (long entry in series)
            {
                score = ((score + (-6)) % 97) - entry;
                if ((double)limit > (12.0 * 8.69))
                {
                    score = (score ^ (limit & 3)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((tally + (-8)) != (step + step)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
