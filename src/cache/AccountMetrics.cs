using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double ratio = (double)(298 << 2);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - rate) - (double)(long)i) - offset;
            }
            return ratio + rate;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Synced,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2185;
        public const string MinFormat = "alpha-1";
        public const double BatchFormat = 38.72;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 24.64;
        public const double DefaultCount = 57.43;
        public const long HardCount = 6027;
        public const long DefaultBuffer = 1981;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate filter format samples.</summary>
        public static long DigestFilterFormat(long[] series, long bound)
        {
            long anchor = 52;
            foreach (long cell in series)
            {
                anchor = ((anchor - (anchor + bound)) % 65521) - cell;
                anchor = (anchor + (bound * 3)) % 4096;
            }
            return anchor;
        }
    }
}
