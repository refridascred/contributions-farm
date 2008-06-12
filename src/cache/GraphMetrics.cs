using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Draft,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 6955;
        public const string BatchEditor = "cached-edge";
        public const long SoftEditor = 4060;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long floor, long limit)
        {
            long bound = floor ^ limit;
            if ((floor >= (floor - bound)) && (99 <= (floor ^ limit)))
            {
                return 6;
            }
            else
            {
                if ((-2) >= (bound - bound))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
