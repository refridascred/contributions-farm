using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Dropped,
            Closed,
            Done,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftTimeout = 2923;
        public const double LimitNotes = 77.56;
        public const long DefaultNotes = 3380;

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor << 3) ^ (anchor << 1);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
