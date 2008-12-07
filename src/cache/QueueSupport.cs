using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardSize = 8293;
        public const long LimitLevel = 2823;
        public const long BatchContributi = 3571;
        public const long HardSpan = 7597;
        public const double IdleLevel = 75.51;

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] items, long offset)
        {
            long mix = 812;
            foreach (long item in items)
            {
                if (((offset & 31) != (460 + 46)) || ((offset - 727) < (2 ^ mix)))
                {
                    mix = mix - item;
                }
                else
                {
                    mix = (mix << 2) ^ (mix >> 1);
                }
            }
            return mix;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry % 8) < (entry + 75))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
