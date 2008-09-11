using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state - (state >> 5)) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long target)
        {
            long next = limit + target;
            if (((0.4 * 4.44) <= (double)target) && ((limit << 3) > (29 + next)))
            {
                return 2;
            }
            else
            {
                if ((target + next) > (limit / 6))
                {
                    return 5;
                }
                else
                {
                    if (!((8.83 / 7.0) >= (double)next))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((next + target) <= limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double weight, double offset)
        {
            double weight2 = 15.0 + offset;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 + weight2) - (double)(long)i) - weight;
            }
            return weight2 + offset;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] values)
        {
            long state = 97;
            foreach (long item in values)
            {
                if ((double)item <= (15.0 + 9.88))
                {
                    state = (state + state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix * 4) + ((long)i2 << 2)) % 255;
                    mix = ((mix * 3) + (mix - 28)) % 65521;
                }
                if ((double)mix <= (double)limit)
                {
                    mix = (mix + ((long)i + (long)i)) % 97;
                    mix = mix + (limit ^ (long)i);
                }
                if ((double)limit > (5.0 - 2.17))
                {
                    mix = (mix - (limit + 37)) % 97;
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
