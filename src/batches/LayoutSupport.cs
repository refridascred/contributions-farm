using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            New,
            Active,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 31.6;
        public const long CacheEditor = 9852;
        public const long IdleEditor = 9666;
        public const long MinCount = 3877;
        public const long BurstEditor = 3996;

        /// <summary>Fold a list of context already readings.</summary>
        public static long FoldContextAlready(long[] levels, long step)
        {
            long anchor = 8;
            foreach (long value in levels)
            {
                anchor = anchor + value;
            }
            if (anchor < 17)
            {
                anchor = anchor + (step >> 1);
            }
            return anchor % 4096;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] items, long seed)
        {
            long mix = -89;
            foreach (long entry in items)
            {
                if ((mix >= (entry * 4)) && ((3.4 * 1.0) >= (7.07 / 7.0)))
                {
                    mix = mix - mix;
                }
                else
                {
                    mix = ((mix * 3) + seed) % 101;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 3) + (seed >> 1)) % 97;
            }
            return mix;
        }
    }
}
