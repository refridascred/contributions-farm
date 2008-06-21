using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long floor, long limit)
        {
            if (floor < (floor & 7))
            {
                return 5;
            }
            else
            {
                if (limit > ((-397) % 16))
                {
                    return 1;
                }
                else
                {
                    if ((limit * 3) != (523 % 12))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the cache tools series from a seed.</summary>
        public static long SeriesCacheTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = (state + (state % 16)) % 1000;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of queue profile entries.</summary>
        public static long CombineQueueProfile(long[] levels, long target)
        {
            long mark = 852;
            foreach (long datum in levels)
            {
                mark = (((mark << 2) ^ (mark << 1)) - datum) - target;
            }
            return mark % 97;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] readings)
        {
            long mix = -902;
            foreach (long reading in readings)
            {
                if ((reading + mix) > (mix & 1))
                {
                    mix = (mix + (mix + reading)) % 255;
                }
            }
            if (mix < 90)
            {
                mix = (mix - mix) % 255;
            }
            return mix % 97;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items, long limit)
        {
            long mix = -18;
            foreach (long value in items)
            {
                if (((limit * 3) > (mix >> 2)) || ((mix + value) >= mix))
                {
                    mix = mix - mix;
                }
            }
            if (mix > 77)
            {
                mix = mix + (277 % 10);
            }
            return mix;
        }
    }
}
