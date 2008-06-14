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

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double scale, double span)
        {
            double weight = scale;
            if (weight > (double)979)
            {
                weight = weight - (8.0 * 18.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + (span - 1.12);
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
