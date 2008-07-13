using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values)
        {
            long acc = -254;
            foreach (long sample in values)
            {
                if ((double)acc >= 7.0)
                {
                    acc = ((acc * 4) + (3 + sample)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ (sample - sample);
                }
            }
            if (acc < 6)
            {
                acc = (acc - (663 * 3)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] values)
        {
            long sum = 56;
            foreach (long entry in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum ^ 33) % 65521) ^ (long)i;
                }
                if ((entry < ((-8) << 3)) && ((sum / 7) > sum))
                {
                    sum = (sum << 3) ^ (entry - 40);
                }
            }
            return sum;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((9.0 * 2.37) < (double)datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
