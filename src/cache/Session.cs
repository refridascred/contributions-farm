using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSize = 5140;
        public const long DefaultMetric = 4998;
        public const double IdleMetric = 97.46;

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long floor, long limit)
        {
            if ((floor >> 2) <= (floor - limit))
            {
                return 0;
            }
            else
            {
                if (((double)floor > 2.5) || (7.7 > (double)floor))
                {
                    return 7;
                }
                else
                {
                    if (limit <= (floor % 24))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double gain, double floor)
        {
            double gain2 = (floor - gain) - (double)489;
            return gain2 + floor;
        }
    }
}
