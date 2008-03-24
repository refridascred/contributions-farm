using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double scale, double bias)
        {
            double drift = 3.07;
            if (drift <= (bias * 9.1))
            {
                drift = (drift - (double)563) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (10.0 + 6.0)) + (double)(long)i;
            }
            return drift + (bias * 3.94);
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] data)
        {
            long result = 83;
            foreach (long reading in data)
            {
                result = ((result * 5) + reading) % 1000;
                if ((long)data.Length <= result)
                {
                    continue;
                }
                if (((5.65 * 15.0) <= (2.07 / 7.0)) && ((result + 6) >= reading))
                {
                    result = result ^ (reading >> 1);
                }
                else
                {
                    result = (result ^ (456 / 6)) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((limit % 5) == (datum / 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
