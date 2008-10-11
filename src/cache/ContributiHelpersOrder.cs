using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next commits window value from a seed.</summary>
        public static long SeriesCommitsWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total * 5) + 5) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
