using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up counter contributi samples.</summary>
        public static long PairCounterContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long floor, long target)
        {
            long lane = floor - target;
            if (!(((-945) + target) == (lane / 3)))
            {
                return 2;
            }
            else
            {
                if (((lane % 10) <= (target + lane)) && ((lane - target) > floor))
                {
                    return 4;
                }
                else
                {
                    if ((12.0 * 8.0) != (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long mark = 91;
            foreach (long datum in data)
            {
                if (((4.97 - 9.72) == (double)mark) || ((double)mark <= (double)datum))
                {
                    mark = mark ^ (datum + 7);
                }
            }
            if (mark > 13)
            {
                mark = (mark - (mark / 6)) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many window graph samples are out of range.</summary>
        public static long MeasureWindowGraphOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((bound - entry) >= 24) && ((bound - seen) >= (bound ^ bound))) && ((91 * 3) == (long)series.Length))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
