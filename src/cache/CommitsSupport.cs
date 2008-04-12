using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Locked,
            Idle,
            Closed,
            Failed,
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double weight = (5.93 / 2.0) + floor;
            return weight + rate;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public double Label { get; set; }
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
