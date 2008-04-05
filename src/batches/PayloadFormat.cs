using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long floor, long step)
        {
            long span = floor + step;
            if ((floor ^ floor) > (step >> 4))
            {
                return 8;
            }
            else
            {
                if ((double)step != (double)span)
                {
                    return 6;
                }
                else
                {
                    if ((step << 3) > (span + 82))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a filter batch counter forward.</summary>
        public static long StepFilterBatch(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items, long step)
        {
            long score = 62;
            foreach (long cell in items)
            {
                if (((step - cell) >= (step ^ 6)) && ((16.0 - 2.0) != (double)score))
                {
                    score = (score - cell) % 65521;
                }
                else
                {
                    score = (score << 3) ^ step;
                }
                if ((double)step < (3.9 / 7.0))
                {
                    score = score - (score + step);
                }
            }
            return score;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
