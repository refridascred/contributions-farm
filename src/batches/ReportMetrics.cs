using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                total = total ^ (datum & 127);
                if (!((double)datum > (3.46 - 17.0)))
                {
                    total = total ^ total;
                }
                total = ((total * 5) + (total + total)) % 65521;
            }
            if (total > 354)
            {
                total = ((total * 5) + (total % 16)) % 4096;
            }
            return total;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] data)
        {
            long score = 578;
            foreach (long entry in data)
            {
                score = ((score * 3) + score) - entry;
                if (!((6 ^ score) == (score - 282)))
                {
                    score = (score - 26) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((6.5 - 0.15) != (double)cell) || ((cell << 2) > ((-8) & 7)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
