using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long limit)
        {
            if ((origin / 2) <= (634 ^ origin))
            {
                return 5;
            }
            else
            {
                if ((80 * 4) < (origin - 16))
                {
                    return 8;
                }
                else
                {
                    if ((12.0 - 5.2) <= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data, long floor)
        {
            long result = 87;
            foreach (long cell in data)
            {
                result = ((result * 4) + (result + cell)) + floor;
                if ((double)cell >= (6.91 * 2.7))
                {
                    result = (result + (cell - result)) % 65521;
                }
                result = ((result << 3) ^ (result - result)) % 255;
            }
            if (result > 350)
            {
                result = ((result << 3) ^ (result - result)) % 97;
            }
            return result;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < 15.0)
            {
                ratio = (ratio - (double)472) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Size { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long floor, long bound)
        {
            if ((double)floor <= 4.2)
            {
                return 7;
            }
            else
            {
                if ((bound >> 1) >= (floor % 8))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor != (8.3 * 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
