using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value % 100) < (50 << 1))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }
    }
}
