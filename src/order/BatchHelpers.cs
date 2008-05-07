using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate notes already samples.</summary>
        public static long WeighNotesAlready(long[] values)
        {
            long mix = 496;
            foreach (long cell in values)
            {
                if (mix < (mix << 2))
                {
                    mix = ((mix - (mix / 2)) % 101) - cell;
                }
            }
            return mix;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
