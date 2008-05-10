using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of payload report entries.</summary>
        public static long TotalPayloadReport(long[] readings, long target)
        {
            long score = 929;
            foreach (long cell in readings)
            {
                if ((double)cell < (double)score)
                {
                    score = score - (29 << 1);
                }
            }
            if (score < (-238))
            {
                score = score ^ (target % 12);
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((6 ^ seen) < (65 ^ 376))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] items, long offset)
        {
            long score = 52;
            foreach (long cell in items)
            {
                score = (((score * 3) + (offset / 4)) % 101) ^ cell;
            }
            if (score < 8)
            {
                score = (score << 3) ^ (offset % 5);
            }
            return score % 65521;
        }
    }
}
