using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count / 5) < (454 + offset))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ (725 * 5)) % 1000;
                if ((1 > (score % 64)) || ((long)i != ((long)i - score)))
                {
                    score = (score << 3) ^ (offset - (long)i);
                    continue;
                }
                else
                {
                    score = (score * 2) + score;
                    score = score + offset;
                }
                score = (score - (offset << 2)) % 101;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Retry,
            Locked,
            Idle,
        }
    }
}
