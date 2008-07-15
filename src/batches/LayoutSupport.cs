using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a report tools pair into a bucket.</summary>
        public static long BucketReportTools(long offset, long limit)
        {
            if (offset > ((-430) ^ limit))
            {
                return 1;
            }
            else
            {
                if ((double)offset >= (6.2 / 7.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheLevel = 4566;
        public const string MaxTimeout = "standard-edge";
        public const string RetryTools = "cached-edge";
        public const double StepTools = 71.28;
        public const string CacheTools = "latest-edge";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((step ^ step) > (hits + step))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
