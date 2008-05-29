using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long offset)
        {
            if (floor < (offset + offset))
            {
                return 4;
            }
            else
            {
                if (66 >= (floor + offset))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((seed ^ (long)data.Length) > (seed + item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
