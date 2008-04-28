using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] levels)
        {
            long anchor = 14;
            foreach (long sample in levels)
            {
                anchor = (anchor - sample) % 65521;
                if ((double)sample <= (3.0 / 7.0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many stream notes samples are out of range.</summary>
        public static long CountStreamNotesOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((9.0 - 13.0) < 2.86)
                {
                    tally = ((tally + 3) - entry) - origin;
                }
            }
            return tally;
        }
    }
}
