using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double ratio = span * 6.37;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (9.63 - 4.97)) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] samples)
        {
            long anchor = 22;
            foreach (long datum in samples)
            {
                if ((anchor - datum) >= anchor)
                {
                    anchor = (anchor - datum) % 97;
                }
                if (!((anchor / 4) >= (datum + datum)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many metrics format samples are out of range.</summary>
        public static long CountMetricsFormatOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(tally < (item * 5)) || ((item <= tally) && ((item & 3) > (tally + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
