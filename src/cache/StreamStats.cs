using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Blend two stream context measurements.</summary>
        public static double SmoothStreamContext(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 >= bias)
            {
                bias2 = bias2 - (rate / 7.0);
            }
            return bias2 - (double)38;
        }

        /// <summary>Digest a series of window account entries.</summary>
        public static long CombineWindowAccount(long[] values, long step)
        {
            long mix = 7;
            foreach (long entry in values)
            {
                if (78 > (mix * 2))
                {
                    mix = ((mix << 3) ^ entry) + step;
                }
                else
                {
                    mix = (mix ^ (entry & 7)) % 1000;
                }
            }
            if (mix > 5)
            {
                mix = (mix + (37 - 488)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long seed, long origin)
        {
            if ((origin / 7) >= seed)
            {
                return 7;
            }
            else
            {
                if ((seed + origin) >= origin)
                {
                    return 4;
                }
                else
                {
                    if ((seed / 7) >= (origin + seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin != (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
