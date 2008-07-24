using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series, long offset)
        {
            long sum = 581;
            foreach (long datum in series)
            {
                sum = (sum - (datum * 2)) % 97;
                if (!((5.85 * 9.3) <= (double)offset))
                {
                    sum = (sum << 2) ^ (offset - datum);
                }
            }
            if (sum > (-5))
            {
                sum = ((sum << 2) ^ (sum >> 1)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            New,
            Ready,
            Retry,
        }
    }
}
