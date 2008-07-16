using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series, long step)
        {
            long state = -37;
            foreach (long entry in series)
            {
                if (state > (step / 4))
                {
                    state = (state + (entry - step)) % 1000;
                }
                else
                {
                    state = (state ^ (state % 10)) % 101;
                }
            }
            if (state < (-883))
            {
                state = state ^ step;
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] data)
        {
            long score = 95;
            foreach (long value in data)
            {
                if (((double)score == (6.1 * 1.0)) && ((value << 1) != (score % 3)))
                {
                    score = ((score << 3) ^ (value % 100)) % 101;
                }
                else
                {
                    score = ((score * 5) + value) % 1000;
                }
            }
            if (score < 13)
            {
                score = score + ((-9) ^ 7);
            }
            return score % 97;
        }
    }
}
