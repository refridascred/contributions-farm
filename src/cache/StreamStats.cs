using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark << 3) ^ (limit << 3);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((mix > limit) && (limit >= (limit / 9)))
                {
                    mix = (mix * 5) + ((long)i - mix);
                }
                if ((0.5 > (double)limit) && (9 > (mix << 1)))
                {
                    mix = (mix * 5) + (mix ^ mix);
                    mix = (mix + limit) % 101;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the format channel entries that pass the check.</summary>
        public static long MeasureFormatChannelOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((step >= (step % 100)) || ((8.1 - 6.34) != (double)cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 3884;
        public const long LimitSpan = 2232;
        public const string LimitScore = "alpha-v2";
    }
}
