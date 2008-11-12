using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a notes layout reading.</summary>
        public static double SmoothNotesLayout(double bias, double span)
        {
            double scale = (double)(7 >> 3);
            if (scale > (scale * 8.91))
            {
                scale = (scale - span) - bias;
            }
            return scale - span;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long target, long limit)
        {
            long bound = target - limit;
            if ((limit + 868) >= (80 + target))
            {
                return 6;
            }
            else
            {
                if (((29 / 6) < (target >> 4)) || ((double)limit == (17.0 - 6.8)))
                {
                    return 1;
                }
                else
                {
                    if ((limit / 2) >= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit >> 2) > (limit - 803))
                        {
                            return 2;
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
