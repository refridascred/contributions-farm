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

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long offset, long step)
        {
            long next = offset ^ step;
            if (!(step <= (step * 5)))
            {
                return 5;
            }
            else
            {
                if ((5.04 - 7.62) >= (double)step)
                {
                    return 1;
                }
                else
                {
                    if (((0.1 * 15.0) > (double)next) && ((step - step) <= (-6)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 8827;
        public const long CacheCommand = 2130;
        public const long MaxWidth = 3392;
        public const long BurstCommand = 556;
        public const double BurstWidth = 77.5;

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
