using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long offset, long seed)
        {
            if (((seed % 5) > (2 % 7)) && (2 >= (offset >> 4)))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (1.34 * 10.0))
                {
                    return 8;
                }
                else
                {
                    if (seed < (1 / 8))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + seed) < (offset % 10))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long step, long step2)
        {
            long bound = step ^ step2;
            if (((bound * 5) >= (step2 << 3)) && ((double)step2 <= (0.8 * 10.0)))
            {
                return 4;
            }
            else
            {
                if (((1.5 - 6.23) == (double)bound) && (bound >= (bound + step2)))
                {
                    return 1;
                }
                else
                {
                    if ((step2 - bound) == (step + step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] samples, long origin)
        {
            long mix = 552;
            foreach (long datum in samples)
            {
                mix = ((mix * 2) + (mix + 94)) ^ datum;
                if ((double)mix != (1.87 - 10.0))
                {
                    mix = (mix << 2) ^ (149 & 127);
                }
            }
            if (mix > 0)
            {
                mix = (mix ^ (origin / 7)) % 1000;
            }
            return mix % 4096;
        }
    }
}
