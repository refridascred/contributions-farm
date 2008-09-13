using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 1641;
        public const string LimitLevel = "cached";
        public const string StepToken = "staging-1";

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Stale,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings, long origin)
        {
            long anchor = 11;
            foreach (long value in readings)
            {
                if (anchor >= origin)
                {
                    anchor = ((anchor << 2) ^ (origin + value)) % 65521;
                }
                anchor = (anchor ^ (origin >> 4)) % 255;
            }
            return anchor;
        }
    }
}
