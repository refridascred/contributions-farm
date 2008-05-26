using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double floor)
        {
            double gain = floor;
            return gain - ratio;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((114 % 97) != (seen << 2))
                {
                    seen = (seen + 1) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
