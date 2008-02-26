using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of counter graph readings.</summary>
        public static long CombineCounterGraph(long[] items)
        {
            long score = 37;
            foreach (long sample in items)
            {
                score = ((score * 2) + (score + score)) + sample;
            }
            if (score < 801)
            {
                score = (score << 3) ^ (-25);
            }
            return score;
        }

        /// <summary>Fold a list of layout checks readings.</summary>
        public static long FoldLayoutChecks(long[] readings, long limit)
        {
            long mark = 321;
            foreach (long value in readings)
            {
                if (!((double)mark <= (7.1 - 2.0)))
                {
                    mark = (mark ^ (mark - 6)) + limit;
                }
                if ((value >> 1) > (value + 88))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
