using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Draft,
            Synced,
            Retry,
            New,
        }

        /// <summary>Audit batch buffer readings against a rule.</summary>
        public static long MeasureBatchBufferGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((double)count == (3.6 / 4.0)))
                {
                    count = ((count + 1) + cell) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((4.0 * 5.8) >= (double)value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
