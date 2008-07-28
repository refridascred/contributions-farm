using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 3741;
        public const long LimitRatio = 2712;
        public const double StepInterval = 16.48;

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 36.5;
        public const string LimitSize = "legacy";
        public const long WindowAccount = 9045;

        /// <summary>Compare every pair of commits batch readings.</summary>
        public static long CompareCommitsBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Stamp { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
