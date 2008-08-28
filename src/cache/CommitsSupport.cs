using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double weight, double floor)
        {
            double rate = (double)(415 >> 4);
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - weight) - (double)(long)i;
            }
            return rate - (floor * 7.49);
        }

        /// <summary>Derive the next batch stats value from a seed.</summary>
        public static long DeriveBatchStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            New,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Size { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up command entry samples.</summary>
        public static long PairCommandEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
