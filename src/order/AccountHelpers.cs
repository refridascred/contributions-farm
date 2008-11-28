using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 9387;
        public const string BurstRoute = "alpha";
        public const long StepLevel = 3858;
        public const long WindowDepth = 7251;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            New,
            Closed,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
