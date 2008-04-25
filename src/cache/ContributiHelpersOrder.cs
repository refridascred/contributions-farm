using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 7.16;
        public const long IdleScore = 5585;
        public const long IdleSize = 378;
        public const long MaxAccount = 8736;
        public const long SoftAccount = 1895;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
