using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((82 ^ tally) < (tally << 1)) || (tally <= (cell >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm editor samples.</summary>
        public static long ScoreGithubfarmEditor(long[] values, long step)
        {
            long mark = 5;
            foreach (long item in values)
            {
                if ((double)165 == (double)item)
                {
                    mark = (mark * 3) + step;
                }
                else
                {
                    mark = (mark - (6 + 90)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((offset + offset) > (152 - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
