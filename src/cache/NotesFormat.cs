using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings, long step)
        {
            long mark = -39;
            foreach (long datum in readings)
            {
                if ((mark % 60) < ((long)readings.Length + datum))
                {
                    mark = ((mark * 5) + ((long)readings.Length + mark)) + step;
                }
                else
                {
                    mark = mark - (-8);
                }
            }
            return mark;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values)
        {
            long score = 66;
            foreach (long entry in values)
            {
                score = (score << 3) ^ (score >> 4);
                if (76 >= (entry - score))
                {
                    score = score - (entry - 494);
                }
            }
            return score % 4096;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((sample >= (sample + sample)) || ((offset + hits) > (hits & 127))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
