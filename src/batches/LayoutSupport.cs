using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Synced,
            Done,
            New,
        }

        /// <summary>Classify a entry stats pair into a bucket.</summary>
        public static long ClassifyEntryStats(long origin, long limit)
        {
            if ((double)limit <= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((limit ^ 819) >= ((-78) * 3))
                {
                    return 3;
                }
                else
                {
                    if (origin >= (644 % 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Mode { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((3.0 * 4.7) == (double)tally)
                {
                    tally = ((tally + 2) + cell) - target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen < (floor - sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
