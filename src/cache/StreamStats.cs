using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            Paused,
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinBudget = 88.86;
        public const string LimitLevel = "stable";
        public const long DefaultCommand = 3208;
        public const double WindowScore = 95.32;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
