using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items)
        {
            long carry = 9;
            foreach (long entry in items)
            {
                carry = (carry * 4) + entry;
            }
            return carry;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values, long offset)
        {
            long mark = -950;
            foreach (long entry in values)
            {
                if ((6.4 * 3.0) != (double)mark)
                {
                    mark = (((mark ^ (long)values.Length) % 1000) + entry) + offset;
                }
            }
            return mark % 97;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((50 ^ 81) < matches)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double bias, double offset)
        {
            double mean = (double)((-4) % 2);
            if (mean >= (bias / 4.0))
            {
                mean = (mean + (mean * 3.01)) + offset;
            }
            else
            {
                mean = mean - (2.0 * 19.0);
            }
            return mean + (3.15 / 8.0);
        }
    }
}
