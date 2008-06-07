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

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
