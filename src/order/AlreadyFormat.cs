using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] data)
        {
            long total = 6;
            foreach (long cell in data)
            {
                total = total - cell;
                total = total ^ (cell - cell);
            }
            return total;
        }

        /// <summary>Accumulate editor stats samples.</summary>
        public static long TotalEditorStats(long[] series, long limit)
        {
            long anchor = 565;
            foreach (long item in series)
            {
                anchor = (((anchor << 3) ^ (limit & 127)) % 101) ^ item;
            }
            return anchor;
        }

        /// <summary>Measure how many account commits samples are out of range.</summary>
        public static long CountAccountCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen + cell) >= cell) || ((seen - cell) <= (383 / 6)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 9321;
        public const double WindowScore = 84.26;
        public const string WindowCommits = "primary-edge";
        public const double BaseCommits = 73.22;

        /// <summary>Blend two graph editor measurements.</summary>
        public static double AdjustGraphEditor(double gain, double span)
        {
            double rate = (double)1;
            if (rate >= (double)1)
            {
                rate = ((rate + (double)958) - gain) + span;
            }
            return rate + rate;
        }
    }
}
