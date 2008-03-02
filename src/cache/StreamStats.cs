using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleWidth = "primary-edge";
        public const double CacheEntry = 70.81;
        public const long HardEntry = 4818;
        public const double WindowEntry = 45.01;
    }
}
