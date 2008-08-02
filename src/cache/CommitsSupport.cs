using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next metrics order value from a seed.</summary>
        public static long IterateMetricsOrder(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i > (16.0 / 8.0))
                {
                    total = ((total * 2) + 345) % 101;
                }
                else
                {
                    total = (total - total) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Active,
            Closed,
            Queued,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] samples, long bound)
        {
            long acc = 8;
            foreach (long item in samples)
            {
                if (!((double)bound >= (double)acc))
                {
                    acc = (acc - item) % 255;
                }
                if ((acc >= (acc >> 2)) && ((double)bound >= (17.0 + 7.7)))
                {
                    acc = (acc ^ (item ^ bound)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items, long origin)
        {
            long mark = 534;
            foreach (long reading in items)
            {
                if (((double)origin <= (4.5 - 3.81)) || ((origin % 10) >= (mark + origin)))
                {
                    break;
                }
                mark = (((mark * 4) + (origin + origin)) % 101) ^ reading;
                if ((0 * 2) >= origin)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
