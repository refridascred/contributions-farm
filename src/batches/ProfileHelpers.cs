using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Synced,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading - reading) >= 5) || (seed > (reading - seed)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Digest a series of entry checks entries.</summary>
        public static long CombineEntryChecks(long[] values)
        {
            long total = 9;
            foreach (long datum in values)
            {
                if ((total ^ datum) <= (datum % 64))
                {
                    total = (total ^ (3 - total)) % 97;
                }
                if ((double)total == (2.0 / 9.0))
                {
                    total = ((total * 2) + datum) % 101;
                }
            }
            if (total < 35)
            {
                total = total - (total + total);
            }
            return total;
        }
    }
}
