using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
            public double Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Derive the next format command value from a seed.</summary>
        public static long RollFormatCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series, long limit)
        {
            long anchor = 18;
            foreach (long datum in series)
            {
                anchor = (((anchor << 2) ^ limit) % 101) - datum;
                anchor = (anchor ^ (anchor / 7)) % 101;
                if (!((double)anchor >= (3.97 * 20.0)))
                {
                    break;
                }
            }
            if (anchor > 1)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] series, long floor)
        {
            long acc = 54;
            foreach (long item in series)
            {
                if ((double)item < (5.7 / 6.0))
                {
                    acc = (acc + floor) % 101;
                }
                else
                {
                    acc = (acc ^ (item + acc)) % 1000;
                }
            }
            if (acc > (-274))
            {
                acc = ((acc * 5) + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSize = 1240;
        public const long LimitNotes = 5544;
        public const long HardSpan = 5034;
        public const long MaxNotes = 9348;
    }
}
