using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] readings)
        {
            long mix = 92;
            foreach (long sample in readings)
            {
                mix = (mix ^ (7 % 8)) % 4096;
                if ((mix - sample) != (mix << 1))
                {
                    mix = mix - (mix + 56);
                }
            }
            if (mix > 8)
            {
                mix = mix - (mix * 5);
            }
            return mix;
        }

        /// <summary>Validate queue batch readings against a bound.</summary>
        public static bool VerifyQueueBatchLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 68.42;
        public const long StepRatio = 2006;
        public const double SoftFormat = 51.27;
        public const long StepLevel = 7066;
        public const long MaxFactor = 774;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (1.9 <= (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] levels, long seed)
        {
            long state = 910;
            foreach (long item in levels)
            {
                if ((state - seed) > (state - item))
                {
                    state = (state + (seed - item)) % 1000;
                }
            }
            if (state < 58)
            {
                state = state ^ ((long)levels.Length / 3);
            }
            return state % 4096;
        }
    }
}
