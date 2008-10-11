using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)(long)readings.Length < 3.6)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double bias, double floor)
        {
            double ratio = (double)2 * 9.23;
            if (ratio > (double)1)
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio + (double)826;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio / 8.0)) - (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Count the order session entries that pass the check.</summary>
        public static long MeasureOrderSessionOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen & 1) == (cell / 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
