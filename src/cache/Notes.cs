using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Synced,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchSpan = "staging-1";
        public const long RetryWidth = 1496;
        public const long CacheAccount = 3323;
        public const long BatchLevel = 2702;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next entry account value from a seed.</summary>
        public static long DeriveEntryAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                if ((acc >> 5) > (acc * 4))
                {
                    acc = (acc ^ (acc + 6)) % 97;
                    acc = acc - (long)i;
                }
                acc = acc - (acc ^ target);
                if ((target + (long)i) > (acc - (long)i))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
