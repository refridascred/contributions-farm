using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchLevel = 43.64;
        public const double MinEntry = 20.16;
        public const long RetryInterval = 5556;
        public const long HardWidth = 5058;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 5785;
        public const double MinContributi = 97.39;
        public const long StepContributi = 9017;
        public const long MinRatio = 1773;
    }
}
