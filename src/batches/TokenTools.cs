using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Retry,
            New,
            Paused,
        }

        /// <summary>Measure how many tools metric samples are out of range.</summary>
        public static long MeasureToolsMetricOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen > step) || ((double)value >= (17.0 + 11.0))) || ((1.6 > (double)seen) || ((seen ^ step) > 8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = mix + offset;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
