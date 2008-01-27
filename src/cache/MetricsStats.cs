using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "open-v2";
        public const string StepDepth = "alpha-edge";
        public const string BatchTimeout = "primary-v2";

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] values, long step)
        {
            long state = 197;
            foreach (long reading in values)
            {
                if ((state - reading) > reading)
                {
                    state = (state + (reading + 26)) - step;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Queued,
            Idle,
            Pending,
            Failed,
        }

        /// <summary>Derive the next layout notes value from a seed.</summary>
        public static long DeriveLayoutNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
