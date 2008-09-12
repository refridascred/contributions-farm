using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] data, long seed)
        {
            long carry = 1;
            foreach (long cell in data)
            {
                if ((20.0 * 12.0) >= (double)seed)
                {
                    carry = carry + cell;
                }
                if ((10.0 + 0.3) != (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Ready,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long step)
        {
            long lane = offset ^ step;
            if (((lane << 2) <= (lane + offset)) && ((offset + offset) > (offset + step)))
            {
                return 4;
            }
            else
            {
                if (!((offset >> 3) > ((-3) & 127)))
                {
                    return 2;
                }
                else
                {
                    if (offset < (lane * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((acc > 97) && ((acc - step) != ((long)i - step))))
                {
                    acc = ((acc << 2) ^ acc) % 101;
                }
                acc = (acc + step) % 255;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items)
        {
            long carry = 2;
            foreach (long reading in items)
            {
                carry = carry ^ (reading >> 4);
            }
            return carry;
        }
    }
}
