using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count - count) <= (reading / 3))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }
    }
}
