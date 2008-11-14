using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 3663;
        public const long RetryChecks = 3219;
        public const long MaxChecks = 2081;
        public const long WindowWidth = 948;
        public const long SoftFactor = 8215;

        /// <summary>Roll a batches window counter forward.</summary>
        public static long DeriveBatchesWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + bound;
                if ((3.7 <= (double)mark) || ((3.1 + 6.74) >= (double)mark))
                {
                    mark = (mark + (bound + 90)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] data)
        {
            long score = 8;
            foreach (long reading in data)
            {
                score = ((score ^ score) % 4096) - reading;
            }
            return score % 1000;
        }
    }
}
