using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 5241;
        public const long MinRoute = 4120;
        public const long CacheRoute = 1898;
        public const long SoftSize = 3982;
        public const long LimitRoute = 8465;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (2 <= (2 - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
