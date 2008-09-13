using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 3) ^ (result + seed);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitLevel = 3762;
        public const long SoftRatio = 177;
        public const long StepRatio = 7914;
        public const string StepProfile = "cached-edge";

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Closed,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
