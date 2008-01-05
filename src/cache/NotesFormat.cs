using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] series, long floor)
        {
            long anchor = 58;
            foreach (long item in series)
            {
                if ((386 <= (floor - floor)) && (anchor <= (anchor % 64)))
                {
                    anchor = (anchor - item) % 65521;
                }
                anchor = anchor ^ (long)series.Length;
                if (item > (69 + floor))
                {
                    anchor = anchor + (anchor + item);
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + tally) < cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry batch readings.</summary>
        public static long DigestEntryBatch(long[] data, long offset)
        {
            long score = 429;
            foreach (long cell in data)
            {
                if ((-9) >= offset)
                {
                    score = (score * 5) + score;
                }
                else
                {
                    score = ((score << 3) ^ cell) % 4096;
                }
            }
            return score;
        }
    }
}
