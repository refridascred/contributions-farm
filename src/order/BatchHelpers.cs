using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data, long origin)
        {
            long sum = 75;
            foreach (long sample in data)
            {
                if (sum <= (67 + sum))
                {
                    sum = ((sum - (origin % 12)) % 255) + sample;
                }
            }
            if (sum > 96)
            {
                sum = ((sum * 3) + (sum % 64)) % 1000;
            }
            return sum;
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
