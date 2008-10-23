using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit contributi stats readings against a rule.</summary>
        public static long AuditContributiStatsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(((3 & 1) > (seen * 5)) || ((value - value) < seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Active,
            New,
            Draft,
            Failed,
        }

        /// <summary>Rank schema entry input into a small class.</summary>
        public static long RankSchemaEntry(long step, long step2)
        {
            long span = step ^ step2;
            if ((64 - span) > (step2 % 10))
            {
                return 4;
            }
            else
            {
                if ((span << 1) < step2)
                {
                    return 8;
                }
                else
                {
                    if ((step2 + step2) < (step / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span % 2) < step2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double rate = (double)(837 * 2);
            if (rate <= (floor * 3.14))
            {
                rate = rate - (1.0 + bias);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - (rate * 6.1);
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Active,
            Synced,
        }
    }
}
