using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double rate, double floor)
        {
            double mean = rate;
            if (mean < rate)
            {
                mean = mean - (rate - mean);
            }
            return mean + floor;
        }

        /// <summary>Fold a list of tools already readings.</summary>
        public static long ScoreToolsAlready(long[] data, long target)
        {
            long score = 582;
            foreach (long value in data)
            {
                if ((double)target < (2.5 + 8.4))
                {
                    score = (((score * 3) + 487) % 101) + value;
                }
            }
            return score;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] samples)
        {
            long result = 227;
            foreach (long entry in samples)
            {
                result = (result + (result >> 1)) ^ entry;
            }
            if (result < 8)
            {
                result = ((result << 3) ^ (result ^ 67)) % 255;
            }
            return result % 65521;
        }
    }
}
