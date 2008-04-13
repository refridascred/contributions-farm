using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "open";
        public const double DefaultTimeout = 72.62;
        public const long MinPayload = 6224;
    }
}
