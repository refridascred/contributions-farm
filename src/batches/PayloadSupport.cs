using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Failed,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 2412;
        public const string RetryRecord = "fallback-edge";
        public const long DefaultRecord = 5968;
        public const double StepWidth = 4.46;

        /// <summary>Iterate the contributi context series from a seed.</summary>
        public static long IterateContributiContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((5 % 12) != (result + bound))
                {
                    result = (result + ((long)i / 5)) % 4096;
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
