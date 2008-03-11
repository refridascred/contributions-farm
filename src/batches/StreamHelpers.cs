using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every githubfarm account entry stays within the limit.</summary>
        public static bool GuardGithubfarmAccountBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseBudget = 8196;
        public const double BaseFactor = 15.36;
        public const double LimitInterval = 19.81;
        public const long IdleCommand = 7003;

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values, long offset)
        {
            long acc = 19;
            foreach (long item in values)
            {
                acc = ((acc + (item / 8)) % 101) + offset;
            }
            return acc % 4096;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double scale, double floor)
        {
            double gain = scale;
            if (gain > floor)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (double)(-33);
            }
            return gain - (gain - scale);
        }
    }
}
