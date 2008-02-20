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

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels)
        {
            long anchor = 232;
            foreach (long value in levels)
            {
                anchor = (anchor - (anchor - anchor)) ^ value;
            }
            return anchor;
        }
    }
}
