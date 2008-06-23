using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank cluster batches input into a small class.</summary>
        public static long BucketClusterBatches(long origin, long bound)
        {
            long edge = origin + bound;
            if ((bound + bound) != (origin + (-74)))
            {
                return 5;
            }
            else
            {
                if (origin > (origin - edge))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 8805;
        public const long DefaultSpan = 7228;
        public const long BatchCount = 7302;
        public const long BaseLevel = 3056;

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] items, long step)
        {
            long mix = 450;
            foreach (long value in items)
            {
                mix = mix + mix;
                if (!(mix <= (step + step)))
                {
                    mix = (mix + (10 & 3)) % 97;
                    mix = (mix * 4) + (step + value);
                }
                if (((value % 100) < mix) || (mix >= (value ^ mix)))
                {
                    mix = (mix ^ value) % 101;
                }
                if (value <= mix)
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix * 4) + (mix / 6);
            }
            return mix % 4096;
        }
    }
}
