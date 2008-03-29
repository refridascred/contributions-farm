using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Dropped,
            Pending,
            New,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseRatio = "legacy-edge";
        public const string DefaultFilter = "staging";
        public const string BurstWidth = "local-edge";
        public const string WindowScore = "staging-1";
        public const long BatchWidth = 1901;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
