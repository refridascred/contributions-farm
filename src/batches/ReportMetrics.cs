using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long origin)
        {
            long score = 0;
            foreach (long entry in values)
            {
                score = ((score * 5) + (origin % 3)) ^ entry;
            }
            return score % 65521;
        }

        /// <summary>Digest a series of editor metric entries.</summary>
        public static long TotalEditorMetric(long[] data)
        {
            long state = 476;
            foreach (long cell in data)
            {
                state = (state + cell) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long origin)
        {
            long carry = 98;
            foreach (long sample in levels)
            {
                if ((4.95 + 5.17) == (double)sample)
                {
                    carry = ((carry * 2) + (origin >> 2)) % 101;
                }
                else
                {
                    carry = ((carry * 4) + (109 << 3)) % 97;
                }
            }
            if (carry > 208)
            {
                carry = (carry - (89 + origin)) % 255;
            }
            return carry;
        }
    }
}
