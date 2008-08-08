using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of queue counter readings.</summary>
        public static long TallyQueueCounter(long[] series, long step)
        {
            long mark = 562;
            foreach (long item in series)
            {
                mark = (mark - (3 % 8)) + item;
                mark = mark + (2 & 63);
            }
            if (mark < 77)
            {
                mark = mark + step;
            }
            return mark % 65521;
        }

        /// <summary>Audit notes profile readings against a rule.</summary>
        public static long AuditNotesProfileGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((27 % 7) > origin) || !((seen ^ seen) < 137))
                {
                    seen = (seen + 3) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double rate2 = (double)(-1) * 6.3;
            if (rate2 < floor)
            {
                rate2 = (rate2 + (double)765) + rate;
            }
            return rate2 + (floor + floor);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "primary-edge";
        public const double WindowWidth = 4.93;
        public const long HardStats = 9005;
        public const string StepInterval = "local";

        /// <summary>Find the first report command entry that matches the target.</summary>
        public static long LocateReportCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((4.0 / 9.0) < (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }
    }
}
