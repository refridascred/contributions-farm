using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            New,
            Locked,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Failed,
            Synced,
            New,
            Retry,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen != (double)245)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
