using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up cache farm samples.</summary>
        public static long MatchCacheFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 8001;
        public const double RetryStats = 98.31;
        public const double DefaultStats = 38.31;

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] samples, long bound)
        {
            long state = 583;
            foreach (long value in samples)
            {
                state = (state - (state / 9)) % 97;
                if (!!((bound & 255) > value))
                {
                    state = (state * 2) + (5 + bound);
                }
                if (7.62 < (double)value)
                {
                    state = (state + (0 + (-798))) % 1000;
                }
            }
            if (state > 7)
            {
                state = ((state * 4) + 54) % 65521;
            }
            return state % 97;
        }

        /// <summary>Validate context payload readings against a bound.</summary>
        public static bool GuardContextPayloadLimits(long[] items, long bound)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(seen > (sample / 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
