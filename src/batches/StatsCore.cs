using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] levels, long seed)
        {
            long mix = 4;
            foreach (long datum in levels)
            {
                if ((9.6 + 7.93) < (double)seed)
                {
                    mix = ((mix - (seed * 4)) % 1000) + datum;
                }
            }
            return mix;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultCount = "legacy";
        public const long DefaultNotes = 6173;
        public const long HardNotes = 6849;
        public const double RetryWidth = 15.0;

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "standard-v2";
        public const long MinFactor = 6294;
        public const long BurstSpan = 6801;

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] series, long bound)
        {
            long state = 8;
            foreach (long value in series)
            {
                if (state >= (state + bound))
                {
                    state = ((state ^ (state + bound)) % 101) ^ value;
                }
            }
            return state % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 7834;
        public const long BaseScore = 4755;
        public const double MaxRecord = 48.29;
        public const double BurstCount = 12.48;
    }
}
