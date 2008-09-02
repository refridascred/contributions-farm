using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a account batch pair into a bucket.</summary>
        public static long RankAccountBatch(long offset, long target)
        {
            long step = offset - target;
            if (!(9.6 <= (14.0 + 0.28)))
            {
                return 6;
            }
            else
            {
                if ((double)956 < (double)target)
                {
                    return 2;
                }
                else
                {
                    if (step <= (34 << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many report entry samples are out of range.</summary>
        public static long TallyReportEntryMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((3.5 / 4.0) > (double)limit)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
