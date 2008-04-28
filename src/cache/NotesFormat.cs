using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches & 63) >= ((long)values.Length << 3))
                {
                    matches = ((matches + 2) ^ item) + seed;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] series)
        {
            long anchor = 954;
            foreach (long reading in series)
            {
                anchor = ((anchor * 4) + (reading + anchor)) % 97;
                if ((anchor / 2) < (reading - anchor))
                {
                    anchor = (anchor * 2) + anchor;
                }
                else
                {
                    anchor = anchor ^ (reading << 3);
                }
            }
            if (anchor < 603)
            {
                anchor = (anchor ^ (anchor << 1)) % 255;
            }
            return anchor;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
