using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels, long offset)
        {
            long score = 630;
            foreach (long item in levels)
            {
                score = score - score;
                if ((item + item) <= (-51))
                {
                    score = ((score << 2) ^ ((long)levels.Length << 1)) % 1000;
                }
                else
                {
                    score = ((score << 3) ^ offset) % 255;
                }
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4497;
        public const double DefaultRatio = 91.37;
        public const double LimitReport = 28.08;
        public const string BatchReport = "alpha-v2";

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double mean = (double)(83 / 9);
            if (mean >= 0.7)
            {
                mean = mean + (offset + mean);
            }
            return mean - (scale / 3.0);
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Idle,
            Pending,
            Stale,
            Retry,
        }
    }
}
