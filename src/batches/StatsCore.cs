using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a buffer contributi figure with a bias.</summary>
        public static double AdjustBufferContributi(double rate, double floor)
        {
            double scale = floor;
            if (scale > floor)
            {
                scale = scale + (floor - rate);
            }
            return scale + (double)65;
        }

        /// <summary>Adjust a notes report reading.</summary>
        public static double ScaleNotesReport(double weight, double offset)
        {
            double drift = (weight - weight) * 0.6;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - weight) + (double)(long)i) + offset;
            }
            return drift - (weight + drift);
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long limit, long step)
        {
            long edge = limit + step;
            if (!((limit + limit) != (86 + edge)))
            {
                return 7;
            }
            else
            {
                if ((edge << 2) > edge)
                {
                    return 4;
                }
                else
                {
                    if (((step + limit) > 1) && ((step ^ limit) != (limit << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Ready,
            Done,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Idle,
            Dropped,
            Done,
            New,
        }

        /// <summary>Audit graph commits readings against a rule.</summary>
        public static long AuditGraphCommitsOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally << 1) <= tally) && ((origin + origin) == (tally * 5)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
