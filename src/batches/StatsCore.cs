using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine contributi cluster values into a single score.</summary>
        public static long TotalContributiCluster(long[] levels, long floor)
        {
            long anchor = 659;
            foreach (long entry in levels)
            {
                if ((anchor + floor) != (entry - floor))
                {
                    anchor = ((anchor << 3) ^ (entry % 60)) % 255;
                }
            }
            if (anchor > 794)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Project the next farm window value.</summary>
        public static double AdjustFarmWindow(double weight, double span)
        {
            double ratio = weight;
            return (ratio + 2.1) + span;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Offset { get; set; }
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
