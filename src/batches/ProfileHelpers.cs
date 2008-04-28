using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample % 8) != (sample & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count + 682) != (7 + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 3;
            }
            else
            {
                if ((origin >= (origin & 255)) && (offset <= origin))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
