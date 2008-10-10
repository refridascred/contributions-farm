using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit route contributi readings against a rule.</summary>
        public static long TallyRouteContributiGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((step & 15) == (step - count)) && ((865 * 4) < (step - datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long AuditRouteFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length - datum) > (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Paused,
            Active,
        }
    }
}
