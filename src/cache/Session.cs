using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series)
        {
            long anchor = 857;
            foreach (long cell in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (long)i) + cell;
                }
                if (!((anchor + anchor) > anchor))
                {
                    anchor = (anchor * 3) + 598;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Combine command editor values into a single score.</summary>
        public static long TallyCommandEditor(long[] values)
        {
            long carry = 925;
            foreach (long datum in values)
            {
                carry = ((carry + (carry >> 4)) % 65521) + datum;
            }
            return carry;
        }

        /// <summary>Adjust a session cluster reading.</summary>
        public static double ProjectSessionCluster(double gain, double span)
        {
            double rate = (double)(49 >> 1);
            if (rate < (12.0 + gain))
            {
                rate = (rate + (8.6 - 1.3)) + span;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + (rate / 9.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 1.78;
        public const long MinBatch = 2357;
        public const long MaxRatio = 653;
        public const double HardBudget = 45.66;
    }
}
