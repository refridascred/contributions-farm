using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate buffer metrics samples.</summary>
        public static long DigestBufferMetrics(long[] items)
        {
            long carry = 3;
            foreach (long datum in items)
            {
                if ((double)datum != (4.0 + 0.8))
                {
                    carry = (carry ^ 9) % 4096;
                }
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry << 3) ^ (8 >> 1)) ^ (long)i;
                }
                carry = ((carry * 5) + (datum << 1)) % 65521;
            }
            return carry % 4096;
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
