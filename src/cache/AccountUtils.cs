using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Done,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Count the batches notes entries that pass the check.</summary>
        public static long MeasureBatchesNotesHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((target & 3) <= (datum - datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
