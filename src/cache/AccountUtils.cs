using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((322 ^ seed) <= (340 + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((count - 2) >= (sample % 24)) && (sample < (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Ready,
            Paused,
            Draft,
            Stale,
        }
    }
}
