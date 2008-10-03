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

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Active,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 6819;
        public const long MaxSize = 5090;
        public const long HardFactor = 8944;
    }
}
