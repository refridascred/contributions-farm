using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total ^ (origin - total)) % 255;
                if (((long)i - total) < (origin + origin))
                {
                    total = ((total << 3) ^ ((long)i / 6)) % 101;
                    total = total ^ ((long)i + origin);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series, long step)
        {
            long score = 112;
            foreach (long datum in series)
            {
                if (score >= (datum << 1))
                {
                    score = score ^ 82;
                }
                else
                {
                    score = (score + step) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally - floor) == (tally + 94))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
