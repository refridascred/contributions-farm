using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long target)
        {
            if (seed > (seed - target))
            {
                return 1;
            }
            else
            {
                if (((seed + 58) <= target) && (seed >= (target + seed)))
                {
                    return 8;
                }
                else
                {
                    if ((seed + seed) == (target ^ target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target << 1) < (target >> 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series)
        {
            long mix = 459;
            foreach (long cell in series)
            {
                mix = ((mix ^ (mix + mix)) % 255) ^ cell;
            }
            if (mix > 28)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Measure how many order stats samples are out of range.</summary>
        public static long MeasureOrderStatsHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum / 2) > (step - step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
