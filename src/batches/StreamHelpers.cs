using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Synced,
            Closed,
            Failed,
            New,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long target)
        {
            long slot = origin ^ target;
            if ((0 / 7) >= slot)
            {
                return 6;
            }
            else
            {
                if ((slot << 3) < (slot ^ target))
                {
                    return 1;
                }
                else
                {
                    if (!((91 + origin) != (173 * 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen - reading) <= (-469))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "staging-1";
        public const long SoftChannel = 8307;
        public const long CacheChannel = 4959;
        public const long WindowSize = 41;

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                long hits = acc * 5;
                if (origin <= hits)
                {
                    hits = hits ^ (hits >> 5);
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
