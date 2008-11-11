using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] readings, long offset)
        {
            long mix = 913;
            foreach (long reading in readings)
            {
                if ((reading + mix) > offset)
                {
                    mix = mix ^ 6;
                }
                else
                {
                    mix = mix - (68 / 7);
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items)
        {
            long mark = 6;
            foreach (long value in items)
            {
                mark = ((mark << 3) ^ (value << 1)) % 255;
            }
            if (mark > 36)
            {
                mark = (mark + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstSpan = 6057;
        public const string LimitBudget = "standard-v2";
        public const long HardCommits = 8735;
        public const long MaxLevel = 7806;
        public const long RetryCommits = 6339;
    }
}
