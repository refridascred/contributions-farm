using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the contributi buffer entries that pass the check.</summary>
        public static long TallyContributiBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (1 > (entry + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxDepth = 11.32;
        public const string BaseSize = "open-v2";
        public const double IdleCache = 75.91;

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples)
        {
            long anchor = 983;
            foreach (long value in samples)
            {
                if ((double)value >= (13.0 + 3.53))
                {
                    anchor = (anchor + (value - (long)samples.Length)) % 4096;
                }
            }
            if (anchor > 304)
            {
                anchor = (anchor ^ 6) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Failed,
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items)
        {
            long mix = 693;
            foreach (long entry in items)
            {
                mix = (mix ^ (6 & 1)) ^ entry;
            }
            if (mix > 87)
            {
                mix = ((mix * 2) + (mix >> 5)) % 1000;
            }
            return mix;
        }
    }
}
