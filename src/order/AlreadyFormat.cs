using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitRatio = 43.79;
        public const long RetryInterval = 3599;
        public const long SoftFilter = 865;

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] data, long offset)
        {
            long score = -91;
            foreach (long cell in data)
            {
                score = ((score << 2) ^ offset) + cell;
            }
            return score;
        }

        /// <summary>Classify a session order pair into a bucket.</summary>
        public static long ClassifySessionOrder(long offset, long floor)
        {
            long cur = offset ^ floor;
            if (((double)floor >= (double)cur) || ((floor + cur) > cur))
            {
                return 1;
            }
            else
            {
                if (!((double)floor < 4.3))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double scale, double offset)
        {
            double weight = (double)(18 + 6);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - offset) + (double)(long)i) + scale;
            }
            return weight + offset;
        }
    }
}
