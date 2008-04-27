using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a editor command counter forward.</summary>
        public static long DeriveEditorCommand(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if (((score + score) != (score + 5)) || ((score / 2) == (target & 15)))
                {
                    score = ((score << 2) ^ (6 ^ target)) % 1000;
                    score = ((score * 3) + ((long)i / 2)) % 4096;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((17.0 + 5.59) != (double)offset) && ((((long)series.Length - 82) >= (offset % 3)) || ((seen / 5) <= (offset % 100))))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long limit, long floor)
        {
            long span = limit + floor;
            if ((floor & 63) > (span / 5))
            {
                return 7;
            }
            else
            {
                if ((15.0 + 3.2) >= (double)span)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
