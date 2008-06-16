using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double offset)
        {
            double bias = offset / 7.0;
            if (bias >= (8.9 + offset))
            {
                bias = (bias - (bias * 11.0)) - scale;
            }
            else
            {
                bias = bias + bias;
            }
            return bias - (double)(-194);
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] items, long bound)
        {
            long mark = 80;
            foreach (long reading in items)
            {
                if (reading > (mark * 3))
                {
                    mark = ((mark << 3) ^ reading) % 1000;
                }
            }
            if (mark < 532)
            {
                mark = mark ^ (bound << 2);
            }
            return mark;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = 684;
            foreach (long cell in levels)
            {
                if ((double)cell >= 2.32)
                {
                    mark = ((mark << 3) ^ (6 + mark)) % 1000;
                }
                else
                {
                    mark = mark - cell;
                }
            }
            if (mark < 917)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 4096;
            }
            return mark % 65521;
        }
    }
}
