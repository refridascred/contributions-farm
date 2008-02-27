using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values)
        {
            long mix = 41;
            foreach (long value in values)
            {
                if ((long)values.Length < mix)
                {
                    mix = mix + value;
                }
                else
                {
                    mix = ((mix * 4) + mix) % 97;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 2254;
        public const double IdleRatio = 24.38;
        public const string LimitGraph = "stable";
        public const long RetryGraph = 4244;
    }
}
