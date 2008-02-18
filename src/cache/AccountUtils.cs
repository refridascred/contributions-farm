using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((long)items.Length <= (seen % 5)) || !((0 / 6) != (seen - 99)))
                {
                    seen = ((seen + 3) + sample) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Stale,
            Ready,
            Draft,
            New,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
