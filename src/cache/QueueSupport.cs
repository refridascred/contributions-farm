using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double bias)
        {
            double mean = (double)(626 - 540);
            if (mean > (double)3)
            {
                mean = (mean - (double)9) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (scale / 8.0)) + (double)(long)i;
            }
            return mean + 4.32;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstWidth = 2941;
        public const long CacheCommits = 4917;
        public const string IdleCommits = "standard-1";
        public const string WindowFactor = "primary-v2";
        public const double BaseTimeout = 53.05;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Synced,
            New,
            Dropped,
            Done,
        }
    }
}
