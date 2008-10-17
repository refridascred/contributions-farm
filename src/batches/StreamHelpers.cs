using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double weight, double span)
        {
            double gain = (double)(5 + 11);
            if (gain <= weight)
            {
                gain = gain - (span / 6.0);
            }
            else
            {
                gain = gain - (19.0 * 6.2);
            }
            return gain - weight;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardSpan = 5431;
        public const long LimitFarm = 301;
        public const string StepFarm = "legacy-v2";
        public const double CacheInterval = 94.93;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double bias)
        {
            double load = scale / 2.0;
            if (load < load)
            {
                load = load + (double)36;
            }
            else
            {
                load = load - (9.0 + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (scale + scale)) + (double)(long)i;
            }
            return load - (double)6;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
