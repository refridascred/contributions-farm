using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] samples, long bound)
        {
            long mix = -762;
            foreach (long entry in samples)
            {
                if ((entry & 3) >= (mix + entry))
                {
                    mix = (mix - 770) % 1000;
                    break;
                }
                if (((double)bound >= (3.0 + 2.02)) || ((double)mix != (5.6 * 8.57)))
                {
                    mix = (mix + (bound + mix)) % 1000;
                }
                else
                {
                    mix = (mix * 2) + (entry + mix);
                }
            }
            if (mix > 3)
            {
                mix = (mix + (bound + bound)) % 101;
            }
            return mix;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long seed, long limit)
        {
            long next = seed - limit;
            if ((limit + next) == (seed - limit))
            {
                return 6;
            }
            else
            {
                if (!((limit / 3) < (next + 6)))
                {
                    return 8;
                }
                else
                {
                    if ((1.6 + 1.9) < (double)next)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit % 10) > limit) || (next > 467))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
