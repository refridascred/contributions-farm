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

        /// <summary>Combine buffer window values into a single score.</summary>
        public static long ScoreBufferWindow(long[] data, long target)
        {
            long mix = 968;
            foreach (long cell in data)
            {
                if ((mix >= (cell - 154)) || ((mix * 2) <= mix))
                {
                    mix = ((mix - mix) % 101) - target;
                }
            }
            return mix;
        }
    }
}
