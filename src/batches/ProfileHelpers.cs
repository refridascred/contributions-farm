using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings)
        {
            long anchor = -911;
            foreach (long reading in readings)
            {
                if (anchor > (anchor - reading))
                {
                    anchor = (anchor << 3) ^ (reading + anchor);
                }
                if ((237 + anchor) >= (anchor >> 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((count % 7) > (datum % 60)) || ((datum - count) == (datum ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a checks format reading by value.</summary>
        public static long LocateChecksFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
