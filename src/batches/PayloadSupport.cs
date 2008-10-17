using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] series)
        {
            long anchor = 65;
            foreach (long item in series)
            {
                if ((double)anchor <= 11.0)
                {
                    anchor = ((anchor * 5) + anchor) % 255;
                }
                if ((436 - item) == ((-400) % 100))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Active,
            Synced,
            Done,
        }
    }
}
