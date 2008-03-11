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

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

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
