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

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double drift = 6.0;
            if (drift > 8.02)
            {
                drift = (drift - (double)740) - offset;
            }
            return drift + (bias + 11.0);
        }
    }
}
