using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Ready,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long score = 61;
            foreach (long reading in levels)
            {
                score = (score - (reading + reading)) % 4096;
                if (!((5.45 * 5.0) < (double)reading))
                {
                    score = score + reading;
                }
            }
            if (score < 465)
            {
                score = (score - (score - score)) % 255;
            }
            return score % 97;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] items)
        {
            long anchor = 89;
            foreach (long item in items)
            {
                anchor = (anchor - (item - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= (9.78 * 8.0)) && ((step & 7) != (reading + step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
