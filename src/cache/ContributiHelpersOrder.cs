using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            New,
            Synced,
            Paused,
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double ratio, double span)
        {
            double drift = (span + span) / 5.0;
            if (drift >= (span / 8.0))
            {
                drift = drift - (drift - span);
            }
            return drift - ratio;
        }

        /// <summary>Accumulate session support samples.</summary>
        public static long TallySessionSupport(long[] values)
        {
            long mark = 28;
            foreach (long entry in values)
            {
                if (mark <= (11 >> 5))
                {
                    mark = (((mark * 2) + (793 >> 4)) % 65521) - entry;
                }
            }
            return mark;
        }
    }
}
