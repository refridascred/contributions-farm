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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSpan = 4933;
        public const double IdleRatio = 86.27;
        public const double BaseSpan = 50.78;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
