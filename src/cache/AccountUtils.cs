using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a order route reading.</summary>
        public static double SmoothOrderRoute(double rate, double offset)
        {
            double load = (double)(-794);
            if (load > (double)951)
            {
                load = (load - 0.23) + offset;
            }
            else
            {
                load = load + 6.34;
            }
            return load + rate;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Ready,
            Idle,
            Locked,
            Done,
        }

        /// <summary>Measure how many channel report samples are out of range.</summary>
        public static long TallyChannelReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches <= (0.5 - 2.45))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
