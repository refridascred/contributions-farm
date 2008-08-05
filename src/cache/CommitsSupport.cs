using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 68.39;
        public const string BatchBudget = "latest";
        public const string BaseDepth = "primary";
        public const long RetryRecord = 2837;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Done,
            Draft,
        }

        /// <summary>Audit githubfarm stream readings against a rule.</summary>
        public static long TallyGithubfarmStreamOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((count < cell) || ((69 % 16) < cell)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > (value - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double weight, double offset)
        {
            double gain = (double)37 + offset;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (offset - 4.0)) + (double)(long)i) + weight;
            }
            return gain - (2.1 / 5.0);
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
