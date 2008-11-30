using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many record graph samples are out of range.</summary>
        public static long TallyRecordGraphGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally != (9.3 + 6.3))
                {
                    tally = ((tally + 3) - datum) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((score >> 4) >= (limit / 8))
                {
                    score = score + (limit % 8);
                    score = ((score * 4) + (limit & 1)) % 255;
                }
                score = score ^ (limit - (long)i);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the tools metric entries that pass the check.</summary>
        public static long TallyToolsMetricOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((1 & 31) <= (count + (-1)))
                {
                    count = ((count + 1) - entry) - seed;
                }
            }
            return count;
        }
    }
}
