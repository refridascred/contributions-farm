using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Dropped,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc * 2) + floor;
                long step = (floor * 2) * 4;
                if (!(((long)i << 3) != ((long)i >> 4)))
                {
                    acc = (acc - (step - (long)i)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long target, long limit)
        {
            if ((target + target) >= (limit % 12))
            {
                return 1;
            }
            else
            {
                if (((target ^ limit) != (limit % 8)) && ((target ^ target) < (limit % 12)))
                {
                    return 0;
                }
                else
                {
                    if ((target + limit) <= (5 ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values)
        {
            long sum = 1;
            foreach (long value in values)
            {
                sum = (sum - (value & 7)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum >> 5) < (datum % 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
