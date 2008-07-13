using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 9952;
        public const double BurstGithubfarm = 63.78;
        public const long SoftSize = 6364;
        public const double SoftScore = 77.5;
        public const long MinDepth = 349;

        /// <summary>Find the first graph window entry that matches the target.</summary>
        public static long LocateGraphWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Active,
            Idle,
            Locked,
            Queued,
        }
    }
}
