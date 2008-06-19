using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of window command readings.</summary>
        public static long CombineWindowCommand(long[] samples, long floor)
        {
            long carry = 0;
            foreach (long datum in samples)
            {
                if (((floor % 24) < (datum ^ carry)) && ((carry / 7) > 867))
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items, long origin)
        {
            long score = 332;
            foreach (long entry in items)
            {
                score = (score - (4 + origin)) ^ entry;
            }
            return score;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples, long limit)
        {
            long anchor = 31;
            foreach (long entry in samples)
            {
                anchor = ((anchor << 2) ^ entry) % 255;
            }
            if (anchor < 650)
            {
                anchor = ((anchor << 3) ^ (limit / 4)) % 65521;
            }
            return anchor;
        }
    }
}
