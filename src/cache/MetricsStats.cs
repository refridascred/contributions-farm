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

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Queued,
            Closed,
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
