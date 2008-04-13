using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((((long)items.Length << 3) < (seen / 6)) && (value < seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen & 7) > reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((count % 16) >= entry) && ((double)offset > (5.87 - 5.29)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items)
        {
            long acc = 81;
            foreach (long item in items)
            {
                acc = ((acc * 4) + (item / 8)) % 255;
                if ((564 > (240 + item)) && ((double)item >= (9.88 - 4.0)))
                {
                    break;
                }
            }
            if (acc > 645)
            {
                acc = (acc * 4) + (acc % 8);
            }
            return acc % 4096;
        }
    }
}
