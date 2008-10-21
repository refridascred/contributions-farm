using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 84;
        public const long SoftOrder = 4967;
        public const double WindowDepth = 79.08;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Synced,
            Queued,
            New,
            Ready,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "fallback-1";
        public const long DefaultScore = 5259;
        public const long HardSession = 6782;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
