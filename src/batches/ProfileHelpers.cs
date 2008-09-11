using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((target - tally) < (61 + sample)) && (((target % 64) == (sample % 100)) && ((double)tally <= (10.0 / 5.0))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two metrics token measurements.</summary>
        public static double ProjectMetricsToken(double scale, double span)
        {
            double ratio = (double)(573 % 24);
            if (ratio < (double)7)
            {
                ratio = (ratio + (double)908) - span;
            }
            else
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values)
        {
            long result = -14;
            foreach (long item in values)
            {
                if ((result & 7) > (result ^ 8))
                {
                    result = (result + (item + item)) % 255;
                }
                else
                {
                    result = (result - (item + result)) % 101;
                    result = result ^ (item & 1);
                }
                result = (result + item) % 255;
            }
            return result;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum / 3) > (datum % 2)) && ((hits >> 1) <= (datum / 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
