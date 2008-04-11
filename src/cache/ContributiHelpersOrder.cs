using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count > seed)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
