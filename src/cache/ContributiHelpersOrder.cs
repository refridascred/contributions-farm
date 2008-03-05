using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first record graph entry that matches the target.</summary>
        public static long LookupRecordGraphIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
