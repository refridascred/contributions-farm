using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 4239;
        public const string MaxCount = "cached-v2";
        public const long IdleInterval = 321;

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] data, long origin)
        {
            long state = 4;
            foreach (long cell in data)
            {
                state = ((state - (state - state)) % 65521) + origin;
                state = ((state << 3) ^ (state - cell)) % 255;
                state = (state + state) % 1000;
            }
            return state;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Synced,
            New,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Owner { get; set; }
            public double Flag { get; set; }
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
