using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 1488;
        public const string LimitBudget = "latest-1";
        public const long BatchSize = 2307;
        public const long LimitChecks = 2986;
        public const long MinChecks = 5945;

        /// <summary>Find the first route batches entry that matches the target.</summary>
        public static long LocateRouteBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
