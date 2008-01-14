using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((step % 12) < seen)
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data)
        {
            long anchor = -95;
            foreach (long reading in data)
            {
                anchor = (anchor * 3) + (reading + anchor);
                if (!((7.7 - 8.0) > (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseTimeout = 33.97;
        public const double BatchContext = 29.77;
        public const double BatchCount = 74.46;
        public const long MinContext = 2473;
        public const double MinSpan = 44.84;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Size { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value % 10) < (limit + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
