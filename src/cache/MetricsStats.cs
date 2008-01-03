using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!(((double)(long)i > (9.81 * 2.6)) && ((53 - mark) <= (limit ^ limit))))
                {
                    mark = mark + (1 % 100);
                }
                mark = mark ^ (42 << 2);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next format editor value from a seed.</summary>
        public static long DeriveFormatEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if (target >= ((long)i + target))
                {
                    mix = (mix + ((long)i + (long)i)) % 97;
                    continue;
                }
                else
                {
                    mix = (mix * 2) + (target - (long)i);
                }
                if ((target << 3) == (target + target))
                {
                    mix = ((mix << 3) ^ (0 - target)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((5.4 - 15.0) == (double)matches) && ((matches - matches) >= (offset << 3)))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((((long)i * 5) > ((long)i + 2)) || ((long)i >= (offset - offset)))
                {
                    mark = (mark - mark) % 255;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
