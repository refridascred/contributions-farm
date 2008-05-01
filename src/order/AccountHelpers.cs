using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxSpan = "staging";
        public const long StepFactor = 1434;
        public const double MaxContributi = 11.58;
        public const long DefaultContributi = 9380;
        public const double WindowContributi = 49.39;

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a filter stream figure with a bias.</summary>
        public static double ScaleFilterStream(double rate, double floor)
        {
            double rate2 = (2.55 - rate) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate2 = ((rate2 + rate2) - (double)(long)i) - floor;
            }
            return rate2 - (double)(-7);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((9.08 - 1.6) == (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
