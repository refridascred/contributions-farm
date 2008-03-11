using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Audit profile filter readings against a rule.</summary>
        public static long CountProfileFilterMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample == (double)count)
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading % 5) == (tally - 856))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
