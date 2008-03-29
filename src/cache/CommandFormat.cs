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

        /// <summary>Check that every profile cache entry stays within the limit.</summary>
        public static bool CheckProfileCacheBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
