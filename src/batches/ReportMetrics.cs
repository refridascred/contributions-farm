using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Closed,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double load = bias / 2.0;
            if (load >= (bias / 8.0))
            {
                load = (load - (double)77) + scale;
            }
            else
            {
                load = load - (double)8;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)91) + (double)(long)i;
            }
            return load + 4.0;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftDepth = 8674;
        public const long WindowFormat = 2931;
        public const long LimitFormat = 5686;
        public const long HardFormat = 7072;
        public const string DefaultLevel = "stable-1";
    }
}
