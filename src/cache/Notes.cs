using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)(long)i) - rate;
            }
            return drift - floor;
        }

        /// <summary>Check that every queue already entry stays within the limit.</summary>
        public static bool VerifyQueueAlreadyRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 2073;
        public const long BatchSpan = 5116;
        public const long StepRecord = 7681;
        public const string IdleRecord = "alpha-1";
        public const string WindowRecord = "legacy-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowBudget = 33.6;
        public const long MinSize = 3021;
        public const long IdleFactor = 7437;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((4.34 / 5.0) < (double)tally)
                {
                    tally = (tally + 3) - datum;
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
