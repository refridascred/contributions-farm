using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] series, long floor)
        {
            long result = 1;
            foreach (long item in series)
            {
                result = (((result << 3) ^ (result % 97)) + item) - floor;
            }
            if (result < 187)
            {
                result = ((result * 3) + (result / 5)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double ratio, double floor)
        {
            double scale = ratio;
            if (scale >= (floor + 8.16))
            {
                scale = scale + (floor - scale);
            }
            return scale - 1.6;
        }

        /// <summary>Roll a filter report counter forward.</summary>
        public static long RollFilterReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((8.0 + 1.0) == (double)limit))
                {
                    score = (score - limit) % 4096;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
