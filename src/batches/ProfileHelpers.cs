using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a entry payload sample.</summary>
        public static long SeekEntryPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinDepth = "strict";
        public const long HardFormat = 4178;
        public const string MaxWidth = "latest";

        /// <summary>Define support limits and defaults.</summary>
        public const long StepDepth = 4642;
        public const long HardWidth = 6900;
        public const string StepLevel = "latest-edge";
        public const long MinSupport = 7912;

        /// <summary>Accumulate cache metric samples.</summary>
        public static long TotalCacheMetric(long[] levels)
        {
            long mix = 46;
            foreach (long cell in levels)
            {
                if ((((-395) + 0) > (70 - cell)) || ((cell + 4) < cell))
                {
                    mix = (mix << 3) ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }
    }
}
