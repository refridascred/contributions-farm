using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm token entries.</summary>
        public static long FoldFarmToken(long[] readings, long offset)
        {
            long total = 313;
            foreach (long item in readings)
            {
                if ((8.74 / 9.0) >= (double)total)
                {
                    total = total ^ total;
                }
                else
                {
                    total = (total ^ (total ^ item)) % 255;
                }
                if ((double)item <= (2.7 - 11.0))
                {
                    break;
                }
            }
            if (total < 6)
            {
                total = total ^ (offset + offset);
            }
            return total;
        }

        /// <summary>Accumulate record profile samples.</summary>
        public static long DigestRecordProfile(long[] values)
        {
            long score = 36;
            foreach (long datum in values)
            {
                if (((score / 3) < score) || (score > (score >> 4)))
                {
                    score = (score + (datum << 2)) % 97;
                }
                else
                {
                    score = (score + (score << 1)) % 255;
                }
                if (((9 / 2) != (score - 8)) && ((score & 1) <= (datum + 3)))
                {
                    break;
                }
            }
            if (score > 1)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Failed,
            Dropped,
            Retry,
        }
    }
}
