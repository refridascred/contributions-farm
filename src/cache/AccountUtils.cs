using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }
    }
}
