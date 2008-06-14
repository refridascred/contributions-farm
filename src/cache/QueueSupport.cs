using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheFactor = 8881;
        public const double LimitTimeout = 80.02;
        public const string MinSize = "staging";
        public const long BatchStats = 726;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - (60 >> 4)) % 101;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
