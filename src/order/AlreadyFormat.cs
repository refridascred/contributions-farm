using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 41.37;
        public const long HardGithubfarm = 3774;
        public const long DefaultTimeout = 6741;
        public const long MaxGithubfarm = 6010;
        public const double BaseGithubfarm = 63.07;

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double drift = offset + (offset - offset);
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (double)73) + (double)(long)i) + gain;
            }
            return drift + (offset + offset);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "alpha-edge";
        public const long BatchLevel = 3052;
        public const long BurstCommand = 5514;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 8157;
        public const double StepReport = 78.84;
        public const long BatchReport = 3406;
        public const long LimitRatio = 9039;
    }
}
