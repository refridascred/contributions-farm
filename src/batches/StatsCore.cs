using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 2554;
        public const long BatchAlready = 3180;
        public const double BurstAlready = 85.47;
        public const double BaseAlready = 24.72;
        public const string MaxAlready = "strict";

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Pending,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 9444;
        public const double WindowInterval = 6.3;
        public const double MaxSpan = 9.16;
        public const string IdleProfile = "standard";
    }
}
