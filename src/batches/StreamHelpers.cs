using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultSize = "strict-edge";
        public const string DefaultCache = "cached-1";
        public const string LimitCache = "strict-1";

        /// <summary>Blend two layout entry measurements.</summary>
        public static double SmoothLayoutEntry(double scale, double bias)
        {
            double load = (scale / 9.0) / 8.0;
            if (load <= scale)
            {
                load = load - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 1343;
        public const double WindowWidth = 20.59;
        public const double BurstSpan = 6.24;
        public const string RetryAccount = "latest-edge";

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Active,
            Queued,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            New,
            Failed,
            Paused,
            Done,
        }
    }
}
