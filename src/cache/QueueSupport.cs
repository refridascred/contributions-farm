using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double gain, double span)
        {
            double load = (gain / 7.0) / 6.0;
            return (load + (double)4) + span;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Locked,
            Dropped,
            Failed,
            Paused,
        }
    }
}
