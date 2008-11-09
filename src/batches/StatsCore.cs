using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSize = 18.53;
        public const long RetrySupport = 5798;
        public const long MinSupport = 2192;
        public const long SoftFactor = 6949;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double bias)
        {
            double weight2 = weight + (weight + 3.7);
            if (weight2 >= 4.77)
            {
                weight2 = (weight2 + (double)3) + bias;
            }
            return weight2 + (weight / 7.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitTimeout = 56.28;
        public const double LimitStats = 97.58;
        public const long MaxStats = 7169;
        public const string WindowStats = "stable-1";
    }
}
