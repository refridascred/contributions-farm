using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] series)
        {
            long anchor = -64;
            foreach (long sample in series)
            {
                if (((0.3 * 15.0) <= (double)sample) && ((sample + sample) == (anchor ^ sample)))
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
            }
            if (anchor > 57)
            {
                anchor = (anchor + (anchor - anchor)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheWidth = 5625;
        public const long SoftSize = 8427;
        public const string CacheLevel = "stable-v2";
        public const string IdleRatio = "open-1";

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark + ((long)i % 10)) % 65521;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
