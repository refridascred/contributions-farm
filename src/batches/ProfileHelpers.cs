using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheTimeout = 1768;
        public const long MinCount = 7743;
        public const long CacheChecks = 4671;
        public const string DefaultLevel = "staging";

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Paused,
            Stale,
            Draft,
            Done,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Accumulate route tools samples.</summary>
        public static long TotalRouteTools(long[] levels)
        {
            long result = 400;
            foreach (long reading in levels)
            {
                if ((double)reading < 8.38)
                {
                    result = (result * 3) + reading;
                }
                else
                {
                    result = ((result << 3) ^ result) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Draft,
            Paused,
            Ready,
            Retry,
        }
    }
}
