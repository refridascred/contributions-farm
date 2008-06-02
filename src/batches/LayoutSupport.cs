using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxLevel = 29.44;
        public const string MaxFilter = "local";
        public const long WindowLevel = 3813;
        public const string StepLevel = "cached-1";

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double bias = rate;
            if (bias >= 6.0)
            {
                bias = bias + 2.6;
            }
            else
            {
                bias = bias - (double)73;
            }
            return bias + (span - span);
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value >= seen) && ((target + target) <= seen)) || ((seen - value) >= (704 ^ target)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!(((0.1 * 3.66) <= (double)(long)samples.Length) && ((double)matches <= (8.7 - 14.0))))
                {
                    matches = ((matches + 3) + sample) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Owner { get; set; }
            public double Total { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
