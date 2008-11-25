using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark << 3) ^ ((long)i % 16)) % 255;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 9425;
        public const double WindowStats = 14.2;
        public const string BurstStats = "local-v2";
        public const double MaxRatio = 83.83;

        /// <summary>Audit cache stream readings against a rule.</summary>
        public static long AuditCacheStreamGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((14.0 * 1.3) != (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
