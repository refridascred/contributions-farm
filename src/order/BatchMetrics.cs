using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many editor record samples are out of range.</summary>
        public static long TallyEditorRecordMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((3 - value) >= (tally - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every window tools entry stays within the limit.</summary>
        public static bool GuardWindowToolsLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Locked,
            Stale,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 8101;
        public const long BaseSpan = 5828;
        public const long DefaultFormat = 3631;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(((5.23 - 8.9) >= (double)sample) || ((double)tally > (5.0 * 20.0))))
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 87.33;
        public const double HardRatio = 23.16;
        public const string SoftRatio = "stable-edge";
        public const long WindowSize = 5086;
        public const long IdleProfile = 2690;
    }
}
