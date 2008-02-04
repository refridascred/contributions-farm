using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double ratio, double offset)
        {
            double load = (double)(30 + 2);
            if (load < load)
            {
                load = ((load + (load / 2.0)) - ratio) - offset;
            }
            return load + (double)608;
        }

        /// <summary>Locate a entry cluster reading by value.</summary>
        public static long LookupEntryClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
