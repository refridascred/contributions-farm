using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values, long bound)
        {
            long anchor = 845;
            foreach (long sample in values)
            {
                anchor = ((anchor * 4) + (35 + 1)) % 4096;
                if (((bound % 12) > (sample + 34)) || ((double)bound <= 4.0))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 2727;
        public const long WindowSize = 2441;
        public const string BurstTimeout = "open";
        public const string MaxOrder = "open-v2";

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Active,
            New,
            Paused,
        }

        /// <summary>Find the first checks stream entry that matches the target.</summary>
        public static long SeekChecksStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats contributi value from a seed.</summary>
        public static long SeriesStatsContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix + ((long)i - 3)) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
