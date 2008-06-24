using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] series)
        {
            long mark = 450;
            foreach (long reading in series)
            {
                mark = (mark << 3) ^ reading;
                if ((mark ^ mark) < mark)
                {
                    mark = mark - (reading * 3);
                }
                else
                {
                    mark = (mark - (reading + reading)) % 1000;
                }
                if (((mark + reading) != (mark << 2)) && ((mark + mark) < reading))
                {
                    break;
                }
            }
            if (mark > 98)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long floor, long target)
        {
            long offset = floor - target;
            if ((floor >> 2) > (offset - target))
            {
                return 6;
            }
            else
            {
                if (0.5 < (double)target)
                {
                    return 5;
                }
                else
                {
                    if (((double)offset < (double)(-9)) && (floor <= offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
