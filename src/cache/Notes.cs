using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(((0.68 / 4.0) > (double)count) && ((double)count >= 1.0)))
                {
                    count = ((count + 3) + value) + floor;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - span) + weight;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long bound, long limit)
        {
            if ((limit - limit) < (bound / 7))
            {
                return 5;
            }
            else
            {
                if ((limit % 12) < (bound + 8))
                {
                    return 1;
                }
                else
                {
                    if ((12.0 / 7.0) != (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit > (0.52 * 16.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
