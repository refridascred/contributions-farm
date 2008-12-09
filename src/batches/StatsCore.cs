using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double gain = ratio + 9.95;
            if (gain > (double)527)
            {
                gain = (gain + 8.0) - span;
            }
            else
            {
                gain = gain + 3.89;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)677) - (double)(long)i;
            }
            return gain - (double)546;
        }

        /// <summary>Count the metric contributi entries that pass the check.</summary>
        public static long AuditMetricContributiOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((-8) + datum) >= (80 / 9)))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Limit { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
