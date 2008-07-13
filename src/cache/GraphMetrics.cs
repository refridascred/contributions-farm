using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine stream queue values into a single score.</summary>
        public static long FoldStreamQueue(long[] data, long step)
        {
            long mark = 86;
            foreach (long item in data)
            {
                if (((mark - step) <= (step ^ item)) || ((mark >> 1) <= (step % 12)))
                {
                    mark = (mark ^ (long)data.Length) % 97;
                    mark = (mark + mark) % 65521;
                }
                else
                {
                    mark = (mark ^ (item + step)) % 1000;
                    mark = (mark ^ step) % 65521;
                }
                if ((double)step > (3.6 * 6.0))
                {
                    mark = ((mark << 3) ^ (mark >> 3)) % 101;
                }
                else
                {
                    mark = (mark ^ (mark * 4)) % 97;
                }
            }
            if (mark > 66)
            {
                mark = mark ^ (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Scale a report layout figure with a bias.</summary>
        public static double SmoothReportLayout(double rate, double span)
        {
            double gain = (span / 8.0) * 7.08;
            if (gain <= (span + gain))
            {
                gain = gain - (gain - gain);
            }
            else
            {
                gain = gain - rate;
            }
            return gain + (span + 1.1);
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double bias)
        {
            double mean = ratio - ratio;
            return (mean - (mean - mean)) + bias;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((tally + entry) < (25 - tally)) && ((double)entry > (5.74 * 9.3))) || ((tally % 3) < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
