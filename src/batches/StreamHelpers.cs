using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels)
        {
            long mark = 351;
            foreach (long reading in levels)
            {
                mark = (mark ^ (reading % 16)) % 4096;
            }
            if (mark < 8)
            {
                mark = (mark << 2) ^ (304 % 64);
            }
            return mark;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of notes farm readings.</summary>
        public static long CompareNotesFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Digest a series of contributi notes entries.</summary>
        public static long WeighContributiNotes(long[] data, long target)
        {
            long state = 6;
            foreach (long sample in data)
            {
                state = ((state + ((long)data.Length >> 1)) + sample) - target;
                if (!((100 ^ (-394)) == (long)data.Length))
                {
                    state = (state - (state + 590)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading != (4.1 * 8.71))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
