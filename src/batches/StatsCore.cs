using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 4477;
        public const double BaseContext = 42.39;
        public const long BatchContext = 3360;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long acc = -6;
            foreach (long datum in levels)
            {
                if ((19 / 7) >= (acc / 5))
                {
                    acc = ((acc ^ acc) % 65521) + datum;
                }
            }
            return acc % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 390;
        public const long DefaultNotes = 6408;
        public const long BaseNotes = 7770;
        public const long SoftNotes = 5140;
        public const long CacheTimeout = 2630;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state + (seed + seed)) % 101) + (long)i2;
                }
                if ((state - (long)i) < 5)
                {
                    state = (state - (seed % 16)) % 101;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
