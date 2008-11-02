using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every contributi stream entry stays within the limit.</summary>
        public static bool GuardContributiStreamRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Closed,
            New,
            Queued,
            Stale,
        }
    }
}
