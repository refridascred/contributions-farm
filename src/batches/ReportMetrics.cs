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

        /// <summary>Roll a window report counter forward.</summary>
        public static long SeriesWindowReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                long count = 900 >> 3;
                sum = (sum + (count * 2)) % 97;
                count = (count - step) % 101;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
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
