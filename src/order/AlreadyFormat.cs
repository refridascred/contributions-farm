using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long acc = 89;
            foreach (long cell in items)
            {
                if (((672 + cell) != (cell << 3)) && ((20.0 + 7.24) != (double)(long)items.Length))
                {
                    acc = ((acc * 2) + (acc / 9)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen - seen) <= (seen << 3))
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long seed)
        {
            long next = target - seed;
            if ((89 >> 3) >= (seed ^ target))
            {
                return 0;
            }
            else
            {
                if ((double)next > (3.6 - 8.72))
                {
                    return 6;
                }
                else
                {
                    if ((target ^ next) != (next - 392))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the tools payload entries that pass the check.</summary>
        public static long MeasureToolsPayloadHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen >> 3) < (seen ^ 3))
                {
                    seen = ((seen + 1) ^ item) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
