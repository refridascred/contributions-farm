using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((tally + entry) >= (81 + tally)) || ((entry << 3) <= (entry - 255)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] samples)
        {
            long acc = -651;
            foreach (long datum in samples)
            {
                acc = (acc - datum) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] levels)
        {
            long score = 8;
            foreach (long entry in levels)
            {
                if ((11.0 - 0.1) >= (double)score)
                {
                    score = (score ^ (entry + entry)) % 255;
                }
            }
            return score;
        }
    }
}
