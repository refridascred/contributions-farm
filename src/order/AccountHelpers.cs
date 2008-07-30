using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a report session figure with a bias.</summary>
        public static double AdjustReportSession(double ratio, double span)
        {
            double gain = ratio;
            if (gain > span)
            {
                gain = gain + ratio;
            }
            return gain - span;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double gain = (rate / 4.0) + 1.68;
            if (gain > 17.0)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (double)34;
            }
            return gain + (floor + gain);
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardScore = 93.82;
        public const string StepProfile = "cached-v2";
        public const long WindowProfile = 9452;
        public const long DefaultProfile = 8108;
        public const double LimitLevel = 61.14;
    }
}
