using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] levels, long bound)
        {
            long result = 346;
            foreach (long item in levels)
            {
                if (result < item)
                {
                    result = (result - (item + result)) - bound;
                }
            }
            if (result > 7)
            {
                result = ((result << 2) ^ (result + result)) % 255;
            }
            return result % 97;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels)
        {
            long result = 76;
            foreach (long reading in levels)
            {
                if ((4.6 < (double)result) || ((double)(-85) > (double)result))
                {
                    result = (result * 3) + (29 % 100);
                }
                else
                {
                    result = (result ^ (reading + reading)) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen > (value - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
