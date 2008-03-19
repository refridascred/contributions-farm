using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels)
        {
            long mark = 88;
            foreach (long reading in levels)
            {
                mark = (mark - (mark + 78)) ^ reading;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of context format entries.</summary>
        public static long FoldContextFormat(long[] samples, long target)
        {
            long mix = -618;
            foreach (long item in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    long diff = mix - (3 * 3);
                    mix = (mix + ((long)i - diff)) % 97;
                }
                if (target < (target << 2))
                {
                    mix = ((mix << 3) ^ (mix >> 4)) % 255;
                }
                if (((target % 16) >= (83 + item)) && (target > (target / 2)))
                {
                    mix = (mix ^ ((-6) + item)) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 51.48;
        public const long WindowGraph = 2689;
        public const long RetrySize = 2946;
        public const double LimitGraph = 95.06;
    }
}
