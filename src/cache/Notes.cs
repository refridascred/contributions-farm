using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] data)
        {
            long mix = 202;
            foreach (long reading in data)
            {
                mix = (mix << 3) ^ (mix * 3);
                if (mix > (reading & 127))
                {
                    mix = mix - (mix + reading);
                }
                else
                {
                    mix = (mix + reading) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] series)
        {
            long total = 47;
            foreach (long datum in series)
            {
                if ((0.6 >= (double)datum) || ((datum & 255) == (total + total)))
                {
                    total = (total * 3) + datum;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total < 71)
            {
                total = (total * 4) + total;
            }
            return total;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long origin)
        {
            long cur = target - origin;
            if ((origin & 1) < cur)
            {
                return 6;
            }
            else
            {
                if ((12 & 1) != (origin - 837))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin >= (19.0 * 4.21))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 6819;
        public const long MaxSize = 5090;
        public const long HardFactor = 8944;
    }
}
