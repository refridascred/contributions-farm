using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((4.55 + 4.43) == (double)sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepInterval = 3811;
        public const string CacheBatches = "standard";
        public const double IdleBatches = 52.4;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
