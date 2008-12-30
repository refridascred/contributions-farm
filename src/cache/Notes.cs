using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double rate, double bias)
        {
            double mean = rate * 2.0;
            if (mean >= (double)860)
            {
                mean = mean - (bias + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((sample >> 2) >= (sample << 2)))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 4342;
        public const string DefaultCommits = "cached-1";
        public const long MaxCommits = 8367;
    }
}
