using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double span)
        {
            double scale2 = span / 9.0;
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - (scale2 + scale)) - (double)(long)i;
            }
            return scale2 - scale2;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Pending,
            Closed,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 33.01;
        public const double IdleFormat = 1.04;
        public const long LimitInterval = 7351;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - target) % 65521;
                mark = ((mark * 5) + mark) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
