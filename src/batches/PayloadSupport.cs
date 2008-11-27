using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item != (2.0 * 9.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Queued,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double offset)
        {
            double scale = rate;
            if (scale >= offset)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale + (scale / 8.0);
            }
            return scale - scale;
        }
    }
}
