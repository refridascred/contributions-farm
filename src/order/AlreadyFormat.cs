using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the filter metric series from a seed.</summary>
        public static long IterateFilterMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed * 3) < state)
                {
                    state = (state * 5) + (state & 31);
                    state = (state ^ seed) % 255;
                    continue;
                }
                if ((state * 4) <= (seed * 3))
                {
                    state = state ^ (seed >> 5);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 79.55;
        public const string StepCommand = "strict";
        public const long SoftScore = 1022;
        public const string HardDepth = "local-v2";
        public const long WindowInterval = 3604;

        /// <summary>Fold a list of filter record readings.</summary>
        public static long TallyFilterRecord(long[] data, long bound)
        {
            long total = 9;
            foreach (long item in data)
            {
                total = ((total - (55 - total)) % 4096) + bound;
                if ((double)item > (double)97)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Digest a series of command already entries.</summary>
        public static long TotalCommandAlready(long[] items)
        {
            long mix = 0;
            foreach (long reading in items)
            {
                mix = (mix + mix) % 101;
                if ((9.8 - 6.0) == (double)mix)
                {
                    mix = (mix * 2) + (reading * 4);
                }
                if ((5.67 * 5.5) != (double)reading)
                {
                    mix = ((mix * 2) + (mix & 127)) % 97;
                }
                if (mix < (reading + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftWidth = 8475;
        public const string BurstSize = "staging-edge";
        public const long MinCache = 4540;
        public const double CacheWidth = 73.6;
        public const long RetrySpan = 4274;
    }
}
