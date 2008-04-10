using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate report profile readings against a bound.</summary>
        public static bool VerifyReportProfileBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Done,
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
