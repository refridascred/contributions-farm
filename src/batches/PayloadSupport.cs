using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((49 >= entry) || !((621 - tally) <= (tally - entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            New,
            Dropped,
            Pending,
            Done,
        }
    }
}
