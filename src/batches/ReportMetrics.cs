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

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long step, long origin)
        {
            if ((step / 2) >= (step << 3))
            {
                return 8;
            }
            else
            {
                if (origin >= (origin << 3))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
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
