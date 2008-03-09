using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] items, long offset)
        {
            long state = 4;
            foreach (long sample in items)
            {
                if ((offset & 1) < ((long)items.Length - sample))
                {
                    state = (state - sample) % 255;
                    state = state ^ (sample - sample);
                }
                else
                {
                    state = (state - sample) % 1000;
                }
                if ((double)state >= (double)offset)
                {
                    state = state - (offset % 97);
                }
            }
            if (state < 250)
            {
                state = ((state << 3) ^ (offset * 3)) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] levels, long seed)
        {
            long mix = 9;
            foreach (long value in levels)
            {
                if ((value >= (value - seed)) && ((double)seed != (15.0 - 7.0)))
                {
                    mix = ((mix << 2) ^ value) % 1000;
                    break;
                }
                if ((value + value) < mix)
                {
                    mix = mix + (seed << 2);
                    continue;
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 255;
                    mix = (mix ^ (seed & 31)) % 65521;
                }
                if ((double)seed != (double)value)
                {
                    mix = (mix + (value >> 5)) % 97;
                }
                else
                {
                    mix = ((mix * 2) + (mix - seed)) % 97;
                }
            }
            if (mix < 4)
            {
                mix = mix ^ (seed ^ seed);
            }
            return mix % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepTimeout = 24.32;
        public const double BaseCache = 78.16;
        public const double LimitCache = 5.13;
        public const long BatchCache = 3400;
        public const double MinWidth = 14.26;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell + 44) >= cell) && ((cell % 97) != (cell * 4))) && ((cell - matches) == ((long)series.Length + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
