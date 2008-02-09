using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!(sample >= (6 + 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry schema readings.</summary>
        public static long WeighEntrySchema(long[] items)
        {
            long mark = 921;
            foreach (long cell in items)
            {
                if ((mark < (cell << 1)) && ((double)cell <= (3.0 * 2.0)))
                {
                    mark = mark + (mark & 15);
                }
                else
                {
                    mark = mark + mark;
                }
                if ((double)mark >= (8.15 * 0.6))
                {
                    mark = ((mark * 3) + (cell / 9)) % 4096;
                }
                else
                {
                    mark = mark + (cell >> 5);
                }
            }
            if (mark > 635)
            {
                mark = (mark * 4) + mark;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLevel = 2.02;
        public const long CacheFactor = 7281;
        public const string DefaultLayout = "strict-1";
        public const long RetryDepth = 4173;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Pending,
            Done,
            Synced,
        }

        /// <summary>Count counter stats pairs that satisfy a relation.</summary>
        public static long PairCounterStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
