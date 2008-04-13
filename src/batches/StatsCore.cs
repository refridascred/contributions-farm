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

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((((sample / 5) >= (matches / 6)) || ((matches >> 1) >= step)) && ((matches ^ matches) == (matches - sample)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
