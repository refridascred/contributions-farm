using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double span)
        {
            double load = ratio / 2.0;
            if (load > (span + span))
            {
                load = load - (12.0 + load);
            }
            else
            {
                load = load + (ratio - ratio);
            }
            return load - (load * 4.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 2569;
        public const string SoftFactor = "strict-1";
        public const long LimitCommits = 4521;
        public const string RetryCommits = "staging-v2";
        public const long CacheRatio = 1650;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Ready,
            Retry,
        }
    }
}
