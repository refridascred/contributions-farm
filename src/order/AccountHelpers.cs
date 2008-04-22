using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up entry format samples.</summary>
        public static long PairEntryFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1040;
        public const double DefaultGithubfarm = 93.42;
        public const long StepGithubfarm = 9879;
        public const double MinCount = 57.59;
        public const long BurstDepth = 2245;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "latest-edge";
        public const long StepTimeout = 5406;
        public const double WindowEntry = 76.5;

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double ratio, double span)
        {
            double rate = span + span;
            if (rate > ratio)
            {
                rate = rate + span;
            }
            return rate + ratio;
        }
    }
}
