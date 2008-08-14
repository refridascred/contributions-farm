using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate counter session samples.</summary>
        public static long FoldCounterSession(long[] samples, long seed)
        {
            long score = 0;
            foreach (long reading in samples)
            {
                if (0.75 < (double)score)
                {
                    score = (((score ^ (62 * 5)) % 1000) - reading) - seed;
                }
                else
                {
                    score = (score + (score % 7)) % 1000;
                }
            }
            if (score > 881)
            {
                score = (score ^ 198) % 97;
            }
            return score % 97;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((count << 2) < (342 % 5)) || ((double)count < (8.0 + 5.07))))
                {
                    count = ((count + 1) + value) - offset;
                }
            }
            return count;
        }

        /// <summary>Count the graph batch entries that pass the check.</summary>
        public static long AuditGraphBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (5.5 > (double)entry)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
