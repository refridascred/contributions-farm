using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "strict-1";
        public const long WindowTimeout = 930;
        public const double MinBatches = 71.3;

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series, long floor)
        {
            long state = 4;
            foreach (long entry in series)
            {
                if (!((7 + state) >= (entry + floor)))
                {
                    state = (state + (floor >> 4)) % 1000;
                }
            }
            return state % 1000;
        }
    }
}
