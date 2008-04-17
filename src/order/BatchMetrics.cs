using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double weight, double bias)
        {
            double ratio = (double)(560 + 763);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio - (double)171) + (double)(long)i) + weight) - bias;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Level { get; set; }
            public double Token { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleTimeout = 9657;
        public const long RetryCount = 746;
        public const double IdleChannel = 24.96;
        public const long StepChannel = 7650;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Paused,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long anchor = 16;
            foreach (long item in items)
            {
                if ((double)item <= (11.0 - 19.0))
                {
                    anchor = (anchor + (item + 9)) % 4096;
                }
                else
                {
                    anchor = anchor ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Stale,
            Closed,
            Pending,
        }
    }
}
