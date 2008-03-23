using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Audit metric command readings against a rule.</summary>
        public static long TallyMetricCommandMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count * 2) < (count + count))
                {
                    count = ((count + 2) - cell) - floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] items, long target)
        {
            long anchor = -22;
            foreach (long sample in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (anchor * 2) + ((long)i / 3);
                    anchor = (anchor << 2) ^ (sample / 5);
                }
                if ((target << 1) <= anchor)
                {
                    anchor = anchor + (target ^ anchor);
                }
                else
                {
                    anchor = anchor ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many account context samples are out of range.</summary>
        public static long CountAccountContextOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits << 1) < target)
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
