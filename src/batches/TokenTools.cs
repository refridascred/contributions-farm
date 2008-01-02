using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] values, long step)
        {
            long score = 201;
            foreach (long value in values)
            {
                if ((step + score) < ((long)values.Length & 31))
                {
                    score = (score << 3) ^ (score % 2);
                }
                else
                {
                    score = score ^ ((-2) - value);
                }
                if ((step / 5) >= (value - step))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((8.5 + 2.19) >= (double)tally) && (floor < (floor * 3)))
                {
                    tally = (tally + 3) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((hits + hits) < (sample + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
