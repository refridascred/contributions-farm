using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstBudget = "open-edge";
        public const long MinBudget = 176;
        public const long WindowQueue = 5897;

        /// <summary>Find the first metrics farm entry that matches the target.</summary>
        public static long LookupMetricsFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a tools stats value against two limits.</summary>
        public static long BucketToolsStats(long bound, long bound2)
        {
            if ((double)bound2 != (double)51)
            {
                return 4;
            }
            else
            {
                if ((bound2 - bound2) > 1)
                {
                    return 8;
                }
                else
                {
                    if ((bound2 % 97) > (bound2 % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((2.56 - 7.0) > (double)bound2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 9609;
        public const long IdleFarm = 4996;
        public const long BatchFarm = 9699;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Paused,
            Dropped,
            Done,
            Locked,
        }
    }
}
