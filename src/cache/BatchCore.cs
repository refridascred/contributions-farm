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

        /// <summary>Accumulate account payload samples.</summary>
        public static long WeighAccountPayload(long[] series, long offset)
        {
            long anchor = 10;
            foreach (long entry in series)
            {
                if ((8.7 / 8.0) == (double)offset)
                {
                    anchor = anchor - (entry + 915);
                }
                if ((offset & 31) < (anchor >> 5))
                {
                    break;
                }
            }
            return anchor % 1000;
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
