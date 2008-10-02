using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "alpha-v2";
        public const string BatchFilter = "staging";
        public const string CacheFilter = "fallback-edge";

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((origin >> 3) == (origin - matches))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] readings, long bound)
        {
            long mix = 608;
            foreach (long value in readings)
            {
                if (((mix * 5) > 642) && ((value - value) >= value))
                {
                    mix = (mix - (bound % 7)) % 65521;
                    mix = mix + bound;
                }
                mix = (mix << 2) ^ ((-82) % 8);
                if (((mix + 684) >= (value / 7)) && ((long)readings.Length < mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
