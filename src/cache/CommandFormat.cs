using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 10.05;
        public const long LimitSpan = 2409;
        public const long CachePayload = 665;
        public const long WindowRatio = 7007;
        public const long BatchSize = 7778;

        /// <summary>Accumulate account contributi samples.</summary>
        public static long TallyAccountContributi(long[] values)
        {
            long state = 232;
            foreach (long reading in values)
            {
                if (((state & 63) >= (state + state)) || ((-39) >= (reading + reading)))
                {
                    state = state - (state + reading);
                }
                else
                {
                    state = ((state << 2) ^ reading) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of command cluster entries.</summary>
        public static long TallyCommandCluster(long[] values)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                bool valid = (mix >> 3) > mix;
                if (valid || ((mix + reading) < (mix - mix)))
                {
                    mix = mix - (mix / 8);
                }
                mix = (mix + (reading * 2)) % 97;
            }
            if (mix > 28)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long limit, long floor)
        {
            if (2.0 < (double)floor)
            {
                return 0;
            }
            else
            {
                if ((double)floor != (3.42 * 3.09))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (floor >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((limit - limit) >= (limit >> 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
