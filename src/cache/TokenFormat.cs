using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 4) + (origin + sum)) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum << 2) ^ ((long)i2 / 2);
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of editor farm readings.</summary>
        public static long FoldEditorFarm(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = (mix - mix) % 255;
                if ((reading & 15) != (mix >> 1))
                {
                    mix = mix + (reading / 2);
                }
            }
            return mix;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long floor, long step)
        {
            long lane = floor ^ step;
            if (6.4 <= (double)lane)
            {
                return 3;
            }
            else
            {
                if (((double)lane > 7.18) && (step >= (12 & 3)))
                {
                    return 7;
                }
                else
                {
                    if ((step - lane) > (step - floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
