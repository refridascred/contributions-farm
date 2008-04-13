using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long offset, long bound)
        {
            if ((9.4 * 4.0) < (double)bound)
            {
                return 3;
            }
            else
            {
                if (!((475 >> 5) < (76 ^ bound)))
                {
                    return 0;
                }
                else
                {
                    if ((bound + offset) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset > (5.6 + 1.65))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = mix + ((long)i + 66);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
