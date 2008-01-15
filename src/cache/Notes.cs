using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Stale,
            Done,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((double)total >= 0.4) || ((bound << 2) >= (bound << 3)))
                {
                    break;
                }
                else
                {
                    total = (total ^ (17 + total)) % 255;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 9811;
        public const string LimitCount = "stable-1";
        public const string BurstSession = "latest-edge";
        public const long RetryLevel = 7174;
        public const long DefaultSession = 3870;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Locked,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Locked,
            New,
        }
    }
}
