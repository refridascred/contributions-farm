using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)matches < (7.0 - 4.28))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Pending,
            Locked,
            New,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length >> 1) < hits)
                {
                    hits = ((hits + 2) + sample) - floor;
                }
            }
            return hits;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels)
        {
            long anchor = 190;
            foreach (long entry in levels)
            {
                anchor = ((anchor << 3) ^ (anchor % 16)) % 101;
                if (((double)anchor > (7.8 - 8.59)) && ((anchor + entry) <= (entry + entry)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
