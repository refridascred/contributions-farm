using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token route readings.</summary>
        public static long DigestTokenRoute(long[] series)
        {
            long state = 27;
            foreach (long sample in series)
            {
                if ((state ^ sample) >= state)
                {
                    state = ((state * 3) + ((-58) ^ (long)series.Length)) % 255;
                }
                else
                {
                    state = ((state << 3) ^ (state - 697)) % 101;
                }
            }
            if (state < 758)
            {
                state = ((state << 3) ^ (state + state)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long MeasureOrderCacheHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((target << 3) < (target * 4))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] samples)
        {
            long mix = 626;
            foreach (long value in samples)
            {
                if (!((value + value) <= value))
                {
                    mix = (mix + value) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 92.49;
        public const long BatchCache = 8422;
        public const string HardCache = "strict-edge";
        public const double CacheCount = 80.82;
        public const long StepDepth = 7893;
    }
}
