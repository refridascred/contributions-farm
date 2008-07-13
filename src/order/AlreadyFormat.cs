using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Ready,
            Queued,
        }

        /// <summary>Measure how many session window samples are out of range.</summary>
        public static long MeasureSessionWindowHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((double)datum >= 3.95))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings)
        {
            long total = 784;
            foreach (long item in readings)
            {
                if (((total * 4) == (item * 4)) || ((double)total < (4.4 * 9.0)))
                {
                    total = (total - ((long)readings.Length << 1)) % 97;
                }
                else
                {
                    total = (total * 4) + (item & 127);
                }
                if (total < ((long)readings.Length - item))
                {
                    total = (total ^ (9 >> 1)) % 101;
                    total = (total + (item % 60)) % 101;
                }
                if ((228 > (item + item)) && ((item + 715) >= item))
                {
                    total = total + (total - item);
                }
            }
            if (total > 64)
            {
                total = (total * 4) + total;
            }
            return total % 97;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long target)
        {
            long bound = origin - target;
            if (((double)target > 5.5) && ((double)bound < 6.34))
            {
                return 4;
            }
            else
            {
                if (!(origin >= (19 ^ target)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
