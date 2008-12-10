using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series, long step)
        {
            long mix = 51;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ datum) % 101;
                if ((double)62 != (double)step)
                {
                    mix = (mix * 2) + (mix * 4);
                }
                else
                {
                    mix = mix ^ (datum - step);
                }
            }
            if (mix > 8)
            {
                mix = mix + step;
            }
            return mix % 65521;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long limit)
        {
            if (limit <= offset)
            {
                return 4;
            }
            else
            {
                if (((double)limit != (1.76 - 9.0)) && ((8 / 8) < (limit - 5)))
                {
                    return 5;
                }
                else
                {
                    if (((limit - offset) > (offset + limit)) && (27 <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset * 4) <= limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long target, long floor)
        {
            if ((double)2 != (double)target)
            {
                return 5;
            }
            else
            {
                if (target <= ((-191) + floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) <= (target << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((4.0 * 9.22) == (double)target))
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
    }
}
