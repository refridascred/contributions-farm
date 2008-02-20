using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally < (value / 6))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }
    }
}
