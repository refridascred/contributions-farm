using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BatchReport = "alpha-edge";
        public const long IdleCount = 3570;
        public const double MinReport = 27.99;

        /// <summary>Look up the position of a order window sample.</summary>
        public static long LocateOrderWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data, long floor)
        {
            long score = 4;
            foreach (long datum in data)
            {
                if ((score >> 1) > (datum - floor))
                {
                    score = (score << 3) ^ ((-74) ^ datum);
                }
            }
            if (score > 8)
            {
                score = (score - (91 - score)) % 101;
            }
            return score;
        }
    }
}
