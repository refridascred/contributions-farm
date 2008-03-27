using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit graph tools readings against a rule.</summary>
        public static long AuditGraphToolsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)tally != (3.0 + 5.6)) && (reading > (floor + floor)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long floor2)
        {
            long slot = floor + floor2;
            if ((slot - (-9)) > (slot >> 2))
            {
                return 2;
            }
            else
            {
                if ((17.0 + 2.89) != (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((double)floor == (6.65 - 9.2)) && ((floor - slot) > floor2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
