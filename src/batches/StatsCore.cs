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

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultCount = 9964;
        public const string CacheWidth = "staging-v2";
        public const string BaseAccount = "standard-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "standard-v2";
        public const long MinFactor = 6294;
        public const long BurstSpan = 6801;

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading / 9) >= matches)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
