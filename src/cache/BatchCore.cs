using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample < 8.98)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cache token readings.</summary>
        public static long ScoreCacheToken(long[] data, long floor)
        {
            long mark = 44;
            foreach (long value in data)
            {
                if ((floor - mark) > (mark - 363))
                {
                    mark = mark + value;
                }
            }
            if (mark > 151)
            {
                mark = (mark - floor) % 101;
            }
            return mark;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
