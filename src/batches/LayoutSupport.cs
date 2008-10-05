using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            New,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Idle,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 4602;
        public const long RetryWidth = 7380;
        public const long MaxBuffer = 436;
        public const string WindowSize = "strict";
        public const long DefaultSize = 1348;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
