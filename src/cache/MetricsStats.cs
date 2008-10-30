using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] levels, long step)
        {
            long mark = 97;
            foreach (long sample in levels)
            {
                if ((sample <= (step & 31)) || ((double)sample < (7.0 - 2.9)))
                {
                    mark = (mark + (sample & 15)) % 1000;
                }
                if ((step << 1) >= (512 + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stats farm samples.</summary>
        public static long ScoreStatsFarm(long[] items, long bound)
        {
            long acc = -463;
            foreach (long value in items)
            {
                acc = ((acc + (bound - acc)) % 1000) ^ value;
                if ((bound << 1) >= (63 * 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit cache counter readings against a rule.</summary>
        public static long CountCacheCounterHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (step >= (matches + (long)readings.Length))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            New,
            Failed,
            Closed,
        }
    }
}
